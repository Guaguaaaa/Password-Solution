using System;

namespace _26th_Task
{

    public class Program{
        static void Main(string[] args){
            //Password checkLength = new Password();
            Console.WriteLine("input here");

            while(true){
                //Console.WriteLine("input here");
                string userinput = Console.ReadLine();

                int userInputLength = userinput.Length;
                //Console.WriteLine(a);
                //inputData(userInputLength);
                //char userInputLengthChar = Convert.ToChar(userInputLength);

                char[] userInputSplit = userinput.ToCharArray();
                
                if(string.IsNullOrEmpty(userinput)){
                    Console.WriteLine("Please enter a password");
                }else{
                    if (Password.inputLength(userInputSplit, userInputLength) == false) {
                        Console.WriteLine("Password length should be 8 symbols or more");
                    }
                    if (Password.inputContainUppercaseLetter(userInputSplit, userInputLength) == false) {
                        Console.WriteLine("Password should contain at least one uppercase letter");
                    }
                    if (Password.inputContainLowercaseLetter(userInputSplit, userInputLength) == false) {
                        Console.WriteLine("Password should contain at least one lowercase letter");
                    }
                    if (Password.inputContainDigit(userInputSplit, userInputLength) == false) {
                        Console.WriteLine("Password should contain at least one digit");
                    }

                    if(Password.inputLength(userInputSplit, userInputLength) == true && Password.inputContainUppercaseLetter(userInputSplit, userInputLength) == true && Password.inputContainLowercaseLetter(userInputSplit, userInputLength) == true && Password.inputContainDigit(userInputSplit, userInputLength) == true){
                        Console.WriteLine("You have Entered the Password: {0}", userinput);
                        break;
                    }
                }
            }
        }
    }
    public class Password
    {
        
        /*public static int inputData(int getUserInputLength){
            return getUserInputLength;
        }*/
        public static bool inputLength(char[] getUserInput, int userInputLength){
            if(userInputLength < 8){
                return false;
            }
            return true;
        }

        public static bool inputContainUppercaseLetter(char[] getUserInput, int userInputLength){
            for(int i = 0;i < userInputLength;i++){
                if(Char.IsUpper(getUserInput[i])){
                    return true;
                }
            }
            return false;
        }

        public static bool inputContainLowercaseLetter(char[] getUserInput, int userInputLength){
            for(int i = 0;i < userInputLength;i++){
                if(Char.IsLower(getUserInput[i])){
                    return true;
                }
            }
            return false;
        }

        public static bool inputContainDigit(char[] getUserInput, int userInputLength){
            for(int i = 0;i < userInputLength;i++){
                if(Char.IsDigit(getUserInput[i])){
                    return true;
                }
            }
            return false;
        }
    }
}
