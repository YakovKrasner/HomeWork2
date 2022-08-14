int DigitPosition = 3; // искомая позиция цифры
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
    if (number < 0) // Если число имеет отрицательное значение, то меняем его значние на положительное
        {
            number = number * -1;
        } 
string numberStringType = Convert.ToString (number); //Преобразуем число в текстовый формат для поиска символа, то есть, цифры, стоящей на искомой позиции с конца.
    if (numberStringType.Length >= DigitPosition) //проверяем, существует ли символ (цифра) на искомой позиции
        {
            Console.WriteLine (numberStringType [DigitPosition - 1]);
        }
    else  
        {
            Console.WriteLine ("Цифры на позиции " + DigitPosition + " нет");
        }


