Console.WriteLine("Velkommen til Fitness CLI! Velg ett av alternativene her nedenfor:");
bool runProgram = true;

while (runProgram) {
    Console.WriteLine("1. Avslutt programmet.");
    Console.WriteLine("2. Regn ut BMI.");

    // Tar brukerinput og lagrer det i input variabelen.
    string input = Console.ReadLine();

    switch (input) {
        case "1":
            runProgram = false;
            break;
        case "2": 
            CalculateBMI();
            break;
        default: 
            Console.WriteLine("Det valget finnes ikke. Velg ett av alternativene her nedenfor:");
            break;
    }
}

static void CalculateBMI() {
    Console.WriteLine("Hva er høyden din i cm? Hvis du er 1.80m, skriv 180.");
    string height = Console.ReadLine();

    // Fiks høyden til å passe bedre i formelen (f. eks. 180 -> 1,80).
    height = height.Substring(0,1) + ',' + height.Substring(1,2);
    
    Console.WriteLine("Hva er vekten din i kg? Hvis du veier 83,6 kilo, skriv 83,6.");
    string weight = Console.ReadLine();

    double bmi = System.Convert.ToDouble(weight) / (System.Convert.ToDouble(height) * System.Convert.ToDouble(height));
    bmi = Math.Round(bmi, 2);
    Console.WriteLine($"Din BMI er {bmi}.");
}