using System;

class Table
{
    string[,] students = new string[3, 3];

    public Table()
    {
        students[0, 0] = "Іван";    students[0, 1] = "Нечай";     students[0, 2] = "Петрович";
        students[1, 0] = "Олена";   students[1, 1] = "Шевченко";  students[1, 2] = "Іванівна";
        students[2, 0] = "Марія";   students[2, 1] = "Нечай";     students[2, 2] = "Олександрівна";
    }

    // Індексатор 
    public string[] this[string column]
    {
        get
        {
            int col = 0;
            if (column == "прізвище") col = 1;
            else if (column == "по батькові") col = 2;

            string[] result = new string[3];
            for (int i = 0; i < 3; i++)
                result[i] = students[i, col];

            return result;
        }
    }
    //кількість студентів з прізвищем Нечай
    public int CountNechai
    {
        get
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (students[i, 1] == "Нечай")
                    count++;
            }
            return count;
        }
    }
}

