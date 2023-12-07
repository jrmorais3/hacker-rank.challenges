namespace WeekOne.CamelCase
{
    public class Result
    {
        public static string CamelCase(string input)
        {
            input = input.Replace("\r", "").Replace("\t", "").Replace("\n", "");
            string[] split = input.Split(';');
            char operation = split[0][0];
            char type = split[1][0];
            string words = split[2];
            char[] letterByLetter = words.ToCharArray();
            string output = string.Empty;

            if (operation.Equals('S'))
            {
                foreach (var letter in letterByLetter)
                {
                    if (char.IsUpper(letter))
                    {
                        output += " " + char.ToLower(letter);
                    }
                    else if (!letter.Equals(')') && !letter.Equals('('))
                    {
                        output += char.ToLower(letter);
                    }
                }
            }
            else if (operation.Equals('C'))
            {
                for (int i = 0; i < letterByLetter.Length; i++)
                {
                    char currentLetter = letterByLetter[i];
                    currentLetter = char.ToLower(currentLetter);

                    if (!currentLetter.Equals(' '))
                    {
                        if (i > 0 && letterByLetter[i - 1].Equals(' '))
                        {
                            currentLetter = char.ToUpper(currentLetter);
                        }
                        output += currentLetter;
                    }
                }

                if (type.Equals('M'))
                {
                    output += "()";
                }
                else if (type.Equals('C'))
                {
                    output = char.ToUpper(output[0]) + output.Substring(1);
                }
            }

            return output.Trim();
        }
    }
}
