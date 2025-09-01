using System;
using System.Threading;

namespace MatrixBrickBreaker
{
    class Program
    {
        // Game constants
        const int WIDTH = 80;
        const int HEIGHT = 25;
        const int PADDLE_WIDTH = 10;
        const int BRICK_ROWS = 6;
        const int BRICK_COLS = 12;

        // Game variables
        static int paddleX = WIDTH / 2 - PADDLE_WIDTH / 2;
        static double ballX = WIDTH / 2;
        static double ballY = HEIGHT - 6;
        static double ballDX = 0.6;  // Much slower ball
        static double ballDY = -0.6;
        static bool[,] bricks = new bool[BRICK_ROWS, BRICK_COLS];
        static char[,] brickChars = new char[BRICK_ROWS, BRICK_COLS];
        static int score = 0;
        static int lives = 3;
        static int level = 1;
        static bool gameActive = true;
        static bool paused = false;
        static Random rand = new Random();

        // Matrix characters
        static char[] matrixSymbols = { '0', '1', '█', '▓', '▒', '░', '╳', '╱', '╲', 'Λ', 'Ω', '∴', '¥', '§', 'µ' };

        static void Main()
        {
            SetupGame();
            ShowStartScreen();
            RunGame();
        }

        static void SetupGame()
        {
            Console.SetWindowSize(WIDTH, HEIGHT);
            Console.SetBufferSize(WIDTH, HEIGHT);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.Clear();

            InitializeBricks();
        }

        static void InitializeBricks()
        {
            for (int row = 0; row < BRICK_ROWS; row++)
            {
                for (int col = 0; col < BRICK_COLS; col++)
                {
                    bricks[row, col] = true;
                    brickChars[row, col] = matrixSymbols[rand.Next(matrixSymbols.Length)];
                }
            }
        }

        static void ShowStartScreen()
        {
            Console.Clear();
            Console.SetCursorPosition(WIDTH / 2 - 15, HEIGHT / 2 - 4);
            Console.WriteLine("█▓▒░ MATRIX BRICK BREAKER ░▒▓█");

            Console.SetCursorPosition(WIDTH / 2 - 12, HEIGHT / 2 - 1);
            Console.WriteLine("BREACH THE DIGITAL MATRIX");

            Console.SetCursorPosition(WIDTH / 2 - 15, HEIGHT / 2 + 2);
            Console.WriteLine("A/← → Left | D/→ → Right");
            Console.SetCursorPosition(WIDTH / 2 - 15, HEIGHT / 2 + 3);
            Console.WriteLine("P → Pause | R → Restart | Q → Quit");

            Console.SetCursorPosition(WIDTH / 2 - 10, HEIGHT / 2 + 5);
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();
        }

        static void RunGame()
        {
            while (gameActive && lives > 0)
            {
                HandleInput();

                if (!paused)
                {
                    UpdateBall();
                    CheckCollisions();
                }

                DrawScreen();
                Thread.Sleep(50); // Stable refresh rate

                if (AllBricksGone())
                {
                    NextLevel();
                }
            }

            ShowEndScreen();
        }

        static void HandleInput()
        {
            // Handle multiple key presses for smooth movement
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        if (paddleX > 1) paddleX -= 4; // Even faster movement
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        if (paddleX < WIDTH - PADDLE_WIDTH - 1) paddleX += 4; // Even faster movement
                        break;
                    case ConsoleKey.P:
                        paused = !paused;
                        break;
                    case ConsoleKey.R:
                        ResetGame();
                        break;
                    case ConsoleKey.Q:
                    case ConsoleKey.Escape:
                        gameActive = false;
                        break;
                }
            }
        }

        static void UpdateBall()
        {
            ballX += ballDX;
            ballY += ballDY;

            // Wall bouncing
            if (ballX <= 1 || ballX >= WIDTH - 2)
            {
                ballDX = -ballDX;
                ballX = Math.Max(1, Math.Min(WIDTH - 2, ballX));
                PlayBeep(800);
            }

            if (ballY <= 1)
            {
                ballDY = -ballDY;
                ballY = 1;
                PlayBeep(800);
            }

            // Ball lost
            if (ballY >= HEIGHT - 1)
            {
                lives--;
                ResetBall();
                PlayBeep(300);
            }
        }

        static void CheckCollisions()
        {
            // Paddle collision
            if (ballY >= HEIGHT - 4 && ballY <= HEIGHT - 3 &&
                ballX >= paddleX && ballX <= paddleX + PADDLE_WIDTH)
            {
                ballDY = -Math.Abs(ballDY);

                // Angle based on hit position (slower ball speed)
                double hitPos = (ballX - paddleX) / PADDLE_WIDTH;
                ballDX = (hitPos - 0.5) * 0.8;  // Slower ball movement

                PlayBeep(600);
            }

            // Brick collision
            int brickStartY = 3;
            int brickWidth = WIDTH / BRICK_COLS;

            for (int row = 0; row < BRICK_ROWS; row++)
            {
                for (int col = 0; col < BRICK_COLS; col++)
                {
                    if (!bricks[row, col]) continue;

                    int brickX = col * brickWidth;
                    int brickY = brickStartY + row;

                    if (ballX >= brickX && ballX < brickX + brickWidth &&
                        ballY >= brickY && ballY < brickY + 1)
                    {
                        bricks[row, col] = false;
                        score += 10 * level;
                        ballDY = -ballDY;
                        PlayBeep(1000);
                        return;
                    }
                }
            }
        }

        static void DrawScreen()
        {
            // Use buffer to prevent flickering
            char[,] screenBuffer = new char[HEIGHT, WIDTH];

            // Initialize buffer with spaces
            for (int y = 0; y < HEIGHT; y++)
                for (int x = 0; x < WIDTH; x++)
                    screenBuffer[y, x] = ' ';

            // Draw top status line
            string statusLine = $"MATRIX BREAKER | SCORE: {score} | LIVES: {lives} | LEVEL: {level} {(paused ? "| PAUSED" : "")}";
            for (int i = 0; i < Math.Min(statusLine.Length, WIDTH); i++)
                screenBuffer[0, i] = statusLine[i];

            // Draw top border
            for (int x = 0; x < WIDTH; x++)
                screenBuffer[1, x] = '═';

            // Draw bricks
            int brickWidth = WIDTH / BRICK_COLS;
            for (int row = 0; row < BRICK_ROWS; row++)
            {
                for (int col = 0; col < BRICK_COLS; col++)
                {
                    if (bricks[row, col])
                    {
                        int brickStartX = col * brickWidth;
                        int brickY = 3 + row;

                        for (int i = 0; i < brickWidth && brickStartX + i < WIDTH; i++)
                        {
                            screenBuffer[brickY, brickStartX + i] = brickChars[row, col];
                        }
                    }
                }
            }

            // Draw paddle
            for (int i = 0; i < PADDLE_WIDTH; i++)
            {
                int x = paddleX + i;
                if (x >= 0 && x < WIDTH)
                    screenBuffer[HEIGHT - 3, x] = '█';
            }

            // Draw ball
            int ballPosX = (int)Math.Round(ballX);
            int ballPosY = (int)Math.Round(ballY);
            if (ballPosX >= 0 && ballPosX < WIDTH && ballPosY >= 0 && ballPosY < HEIGHT)
                screenBuffer[ballPosY, ballPosX] = '@';

            // Draw side borders
            for (int y = 1; y < HEIGHT - 1; y++)
            {
                screenBuffer[y, 0] = '║';
                screenBuffer[y, WIDTH - 1] = '║';
            }

            // Draw bottom border
            for (int x = 0; x < WIDTH; x++)
                screenBuffer[HEIGHT - 1, x] = '═';

            // Render buffer to console (no flickering)
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    Console.Write(screenBuffer[y, x]);
                }
                if (y < HEIGHT - 1) Console.WriteLine();
            }
        }

        static bool AllBricksGone()
        {
            for (int row = 0; row < BRICK_ROWS; row++)
            {
                for (int col = 0; col < BRICK_COLS; col++)
                {
                    if (bricks[row, col]) return false;
                }
            }
            return true;
        }

        static void NextLevel()
        {
            level++;
            lives++; // Bonus life
            InitializeBricks();
            ResetBall();

            Console.Clear();
            Console.SetCursorPosition(WIDTH / 2 - 8, HEIGHT / 2);
            Console.WriteLine($"LEVEL {level} ACCESSED");
            Console.SetCursorPosition(WIDTH / 2 - 10, HEIGHT / 2 + 2);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void ResetBall()
        {
            ballX = paddleX + PADDLE_WIDTH / 2;
            ballY = HEIGHT - 6;
            ballDX = rand.Next(-1, 2) == 0 ? -0.3 : 0.3;  // Slower reset speed
            ballDY = -0.3;
        }

        static void ResetGame()
        {
            score = 0;
            lives = 3;
            level = 1;
            paddleX = WIDTH / 2 - PADDLE_WIDTH / 2;
            InitializeBricks();
            ResetBall();
            paused = false;
        }

        static void ShowEndScreen()
        {
            Console.Clear();
            Console.SetCursorPosition(WIDTH / 2 - 12, HEIGHT / 2 - 2);

            if (lives <= 0)
            {
                Console.WriteLine("█▓▒░ SYSTEM CRASHED ░▒▓█");
            }
            else
            {
                Console.WriteLine("█▓▒░ MATRIX LIBERATED ░▒▓█");
            }

            Console.SetCursorPosition(WIDTH / 2 - 8, HEIGHT / 2);
            Console.WriteLine($"FINAL SCORE: {score}");
            Console.SetCursorPosition(WIDTH / 2 - 6, HEIGHT / 2 + 1);
            Console.WriteLine($"REACHED LEVEL: {level}");

            Console.SetCursorPosition(WIDTH / 2 - 10, HEIGHT / 2 + 3);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            Console.ResetColor();
            Console.CursorVisible = true;
        }

        static void PlayBeep(int frequency)
        {
            try
            {
                Console.Beep(frequency, 100);
            }
            catch
            {
                // Ignore if beep not supported
            }
        }
    }
}