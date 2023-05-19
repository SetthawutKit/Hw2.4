class MainClass {
    public static void Main(string[] args) {
        string[] inputs = Console.ReadLine().Split(' ');
        int N = int.Parse(inputs[0]);
        int K = int.Parse(inputs[1]);

        inputs = Console.ReadLine().Split(' ');
        int[] population = Array.ConvertAll(inputs, int.Parse);

        int maxCustomers = 0;
        for (int i = 0; i < N; i++) {
            int totalCustomers = CalculateTotalCustomers(population, N, K, i);
            if (totalCustomers > maxCustomers) {
                maxCustomers = totalCustomers;
            }
        }

        Console.WriteLine(maxCustomers);
    }

    static int CalculateTotalCustomers(int[] population, int N, int K, int index) {
        int totalCustomers = 0;
        for (int j = index - K; j <= index + K; j++) {
            if (j >= 0 && j < N) {
                totalCustomers += population[j];
            }
        }
        return totalCustomers;
    }
}