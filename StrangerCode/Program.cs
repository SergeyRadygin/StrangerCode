public class StrangerCode
{
    static void Main()
    {
        var lines = new string[12];

        lines[0] = "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ";
        lines[1] = "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой";
        lines[2] = "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть";
        lines[3] = "если особенно упорно подойдешь к делу";
        lines[4] = "";
        lines[5] = "будет Трудно конечнО";
        lines[6] = "Код ведЬ не из простых";
        lines[7] = "очень ХОРОШИЙ код";
        lines[8] = "то у тебя все получится";
        lines[9] = "и я буДу Писать тЕбЕ еще";
        lines[10] = "";
        lines[11] = "чао";

        var transcript = DecodeMessage(lines);

        Console.WriteLine(transcript);
    }
    private static string DecodeMessage(string[] lines)
    {
        var wordsList = new List<string>();

        for (int i = 0; i < lines.Length; i++)
        {
            for (int j = 0; j < lines[i].Split(' ').Length; j++)
            {
                if (lines[i].Length == 0)
                    continue;
                if (char.IsUpper(lines[i].Split(' ')[j], 0))
                    wordsList.Add(lines[i].Split(' ')[j]);
            }
        }
        wordsList.Reverse();
        var sentence = string.Join(" ", wordsList);
        return sentence;
    }
}
