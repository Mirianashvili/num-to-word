using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_to_word
{
    class NumberConverter
    {
        public int number;
        public string word;
        public string[] suffixes = {"ნული","ერთ","ორ","სამ","ოთხ","ხუთ","ექვს","შვიდ","რვა","ცხრა","ათი","თერთმეტი","თორმეტი","ცამეტი","თოთხმეტი","თხუთმეტი","თექვსმეტი","ჩვიდმეტი","თვრამეტი","ცხრამეტი","ოცი"};
        public NumberConverter(int number)
        {
            this.number = number;
            word = "";
        }

        public int getNumber()
        {
            return number;
        }

        public void setNumber(int number)
        {
            this.number = number;
        }

        private string getTwentyPreffix(int num)
        {
            return (num == 3) ? "ოცდა" : "მოცდა";
        }

        private string getNinePreffix(int num)
        {
            return (num == 8 || num == 9) ? "" : "ი";
        }

        public string toWord()
        {

            CheckNegative();
            CheckZero();
            Check10K();

            if (word.Length != 0) return word;

            if (NumberOfDigits(number) == 4)
            {
                int hundred = number / 1000;
                number %= 1000;
                if (number == 0)
                {
                    if (hundred == 1) return "ათასი";
                    return suffixes[hundred] + "ი ათასი";
                }
                else
                {
                    if (hundred > 1)
                        word += suffixes[hundred] + getNinePreffix(hundred) + " ათას ";
                    else word += "ათას ";
                }
            }

            if (NumberOfDigits(number) == 3)
            {
                int hundred = number / 100;
                number %= 100;
                if (number == 0)
                {
                    if (hundred == 1) return "ასი";
                    else return suffixes[hundred] + "ასი";
                }
                else
                {
                    if (hundred > 1)
                        word += suffixes[hundred] + " ას ";
                    else word += "ას ";
                }
            }

            if (NumberOfDigits(number) == 2)
            {
                if (number > 9 && number <= 20)
                {
                    return suffixes[number];
                }
                int twenty = number / 20;
                number %= 20;
                if (twenty > 1)
                {
                    if (number == 0)
                    {
                        word += suffixes[twenty] + "მოცი";
                    }
                    else
                    {
                        word += suffixes[twenty] + getTwentyPreffix(twenty) + ((number >= 10) ? suffixes[number] : ""); ;
                    }
                }
                else
                    word += "ოცდა" + ((number >= 10) ? suffixes[number] : "");
                if (number == 0) return word;
            }
            if (NumberOfDigits(number) == 1)
            {
                word += suffixes[number] + getNinePreffix(number);
            }
            return word;
        }

        private void Check10K()
        {
            if (NumberOfDigits(number) == 5 && word == "") word = "ათი ათასი";
        }

        private void CheckZero()
        {
            if (number == 0 && word == "") word = suffixes[0];
        }

        private void CheckNegative()
        {
            if (number < 0) word = "არასწორია ფორმატი!";
        }

        private int NumberOfDigits(int num)
        {
            return num.ToString().Length;
        }
    }
}
