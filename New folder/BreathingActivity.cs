   static void BreathingActivity()
        {
            Console.Clear();
            Console.WriteLine("Breathing Activity");
            Console.WriteLine(" Welcome to breathing activity. This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

            Console.Write("Enter the duration of the activity in seconds: ");
            int duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Prepare to begin...");
            Thread.Sleep(3000);

            for (int i = 0; i < duration; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Breathe in...");
                }
                else
                {
                    Console.WriteLine("Breathe out...");
                }

                Thread.Sleep(1000);
            }

            Console.WriteLine("Good job! You have completed the Breathing Activity for {0} seconds.", duration);
            Thread.Sleep(3000);
        }
        