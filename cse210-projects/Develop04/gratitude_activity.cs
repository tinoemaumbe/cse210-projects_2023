

{
    gratitude_activity


        static void Gratitude()
        {
            
            // The standard starting message and prompt for the duration
            Console.WriteLine("Welcome to the gratitude activity!");
            Console.WriteLine("This activity will help you appreciate the good things in your life by having you reflect on some prompts.");
            Console.WriteLine();
            Console.Write("How long do you want to do this activity (in minutes)? ");
            
            int duration = int.Parse(Console.ReadLine());
            
            // Start the timer and display a random prompt
            DateTime startTime = DateTime.Now;
            
            int promptIndex = random.Next(gratitudePrompts.Count);
            string prompt = gratitudePrompts[promptIndex];
            
            Console.WriteLine();
            Console.WriteLine(prompt);
            
            // Remove the prompt from the list so it won't be repeated
            gratitudePrompts.RemoveAt(promptIndex);
            
            // If the list is empty, refill it with all the prompts
            if (gratitudePrompts.Count == 0)
            {
                gratitudePrompts.AddRange(new List<string>()
                {
                    "What are you grateful for today?",
                    "Who are some people that make your life better?",
                    "What is something that made you smile recently?",
                    "What is a positive quality that you have?",
                    "What is something that you enjoy doing?"
                });
            }
            
            // Loop until the duration is reached
            while ((DateTime.Now - startTime).TotalMinutes < duration)
            {
                // Pause for several seconds before showing another prompt
                Spinner(5);
                
                // Display a random prompt from the list
                promptIndex = random.Next(gratitudePrompts.Count);
                prompt = gratitudePrompts[promptIndex];
                
                Console.WriteLine(prompt);
                
                // Remove the prompt from the list so it won't be repeated
                gratitudePrompts.RemoveAt(promptIndex);
                
                // If the list is empty, refill it with all the prompts
                if (gratitudePrompts.Count == 0)
                {
                    gratitudePrompts.AddRange(new List<string>()
                    {
                        "What are you grateful for today?",
                        "Who are some people that make your life better?",
                        "What is something that made you smile recently?",
                        "What is a positive quality that you have?",
                        "What is something that you enjoy doing?"
                    });
                }
                
                // Check if the duration is reached before showing another prompt
                if ((DateTime.Now - startTime).TotalMinutes >= duration)
                {
                    break;
                }
                
            }
            
            // The standard finishing message for all activities
            Console.WriteLine();
            Console.WriteLine("Thank you for doing the gratitude activity!");
            Console.WriteLine("I hope you feel more grateful and happy.");
            
        }
    }