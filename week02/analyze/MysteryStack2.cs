public static class MysteryStack2 {
    private static bool IsFloat(string text) {
        return float.TryParse(text, out _);
    }

    public static float Run(string text) { //6 2 + 5 3 - /
        var stack = new Stack<float>(); // stack created
        foreach (var item in text.Split(' ')) { //"5" "3" "7" "+" "*"
            if (item == "+" || item == "-" || item == "*" || item == "/") { //+,*
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!"); // the stackhas less then two numbers (impossible to make a operation)

                var op2 = stack.Pop(); // 5
                var op1 = stack.Pop(); // 3
                float res;
                if (item == "+") { // true
                    res = op1 + op2; // 8
                }
                else if (item == "-") {
                    res = op1 - op2;  // 2
                }
                else if (item == "*") { 
                    res = op1 * op2; //
                }
                else {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!"); // the text has no numbers

                    res = op1 / op2;
                }

                stack.Push(res); //8, 2
            }
            else if (IsFloat(item)) {
                stack.Push(float.Parse(item)); // push 5, 3, 7
            }
            else if (item == "") {
            }
            else {
                throw new ApplicationException("Invalid Case 3!"); // text is empyty
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!"); //end the operation and has more then 1 result == wrong

        return stack.Pop();
    }
}