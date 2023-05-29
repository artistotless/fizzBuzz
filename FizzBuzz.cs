namespace Algos
{
    public class FizzBuzz
    {
        public void Start()
        {
            var queue = new Queue<(int, string)>();

            bool matched = false;

            var restoreQueue = () =>
            {
                queue.Enqueue((3, "Fizz"));
                queue.Enqueue((5, "Buzz"));

                matched = false;
            };

            for (int i = 0; i <= 100; i++)
            {
                if (queue.TryDequeue(out var value))
                {
                    if (i % value.Item1 == 0)
                    {
                        Console.Write($"{(!matched ? $"{i} - " : string.Empty)}{value.Item2}");
                        matched = true;
                    }
                }
                else
                {
                    i++;
                    if (matched) Console.WriteLine();
                    restoreQueue();
                }

                i--;
                continue;
            }
        }
    }
}
