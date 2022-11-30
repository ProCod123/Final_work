void GetArray()
    {
    string[] arrayInput = new string[5];
    Console.WriteLine("Введите элементы массива");
    //Кол-во элементов с длиной <= 3 сохраним в count
    int count = 0; 
    for (int i = 0; i < arrayInput.Length; i++)
        {
            Console.Write($"{i}-й элемент: ");
            arrayInput[i] = Console.ReadLine();
            if (arrayInput[i].Length <= 3 && arrayInput[i] != "") count++;
        }  
    Console.Write("Получен массив: ");
    Console.WriteLine("[{0}]", string.Join(", ", arrayInput));

    //Заполняем новый массив и выводим в консоль
    string[] arrayOutput = new string[count];
    int n = 0;
    for (int i = 0; i < arrayInput.Length; i++)
        {
            if (arrayInput[i].Length <= 3 && arrayInput[i] != "")
            {
                arrayOutput[n] = arrayInput[i];
                n++;
            } 
        }
    Console.Write("Сформирован новый массив: ");    
    Console.WriteLine("[{0}]", string.Join(", ", arrayOutput));   
    }



GetArray();



