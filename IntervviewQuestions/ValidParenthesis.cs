using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervviewQuestions
{
    /*
     *  Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
        determine if the input string is valid.

        An input string is valid if:

        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
 

        Example 1:

        Input: s = "()"
        Output: true
        Example 2:

        Input: s = "()[]{}"
        Output: true
        Example 3:

        Input: s = "(]"
        Output: false
        Example 4:

        Input: s = "([)]"
        Output: false
        Example 5:

        Input: s = "{[]}"
        Output: true
     */

    /*
     *  Solution: Stacks can be used to check whether the given expression has balanced symbols. This
        algorithm is very useful in compilers. Each time the parser reads one character at a time. If the
        character is an opening delimiter such as (, {, or [- then it is written to the stack. When a closing
        delimiter is encountered like ), }, or ]- the stack is popped. The opening and closing delimiters
        are then compared. If they match, the parsing of the string continues. If they do not match, the
        parser indicates that there is an error on the line. A linear-time O(n) algorithm based on stack can
        be given as:
        Algorithm
        a) Create a stack.
        b) while (end of input is not reached)
        1) If the character read is not a symbol to be balanced, ignore it.
        2) If the character is an opening symbol like (, [, {, push it onto the stack
        3) If it is a closing symbol like ),],}, then if the stack is empty report an
        error. Otherwise pop the stack.
        4) If the symbol popped is not the corresponding opening symbol, report an
        error.
        c) At end of input, if the stack is not empty report an error
     * 
     */
    public class ValidParenthesis
    {
        public bool Validate(string s)
        {


            if (string.IsNullOrWhiteSpace(s))
                return true;

            Stack<char> stk = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case ')':
                        if (stk.Count() > 0 && stk.Peek() == '(')
                            stk.Pop();
                        else
                            return false;
                        break;
                    case '}':
                        if (stk.Count() > 0 && stk.Peek() == '}')
                            stk.Pop();
                        else
                            return false;
                        break;
                    case ']':
                        if (stk.Count() > 0 && stk.Peek() == ']')
                            stk.Pop();
                        else
                            return false;
                        break;
                    default:
                        stk.Push(s[i]);
                        break;
                }
            }

            return stk.Count() > 0 ? false : true;
        }
    }
}
