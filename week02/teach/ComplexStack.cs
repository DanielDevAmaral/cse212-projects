public static class ComplexStack {
    public static bool DoSomethingComplicated(string line) { //(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(' or '[' or '{') {
                stack.Push(item); //stack: ([((([(([
            }
            else if (item is ')') { //true
                if (stack.Count == 0 || stack.Pop() != '(') // true
                    return false; 
            }
            else if (item is ']') { //true
                if (stack.Count == 0 || stack.Pop() != '[') //false
                    return false;
            }
            else if (item is '}') { //false
                if (stack.Count == 0 || stack.Pop() != '{') 
                    return false;
            }
        }

        return stack.Count == 0;
    }
}