using System;
using System.Collections.Generic;

namespace Leetspeak
{
    public class LeetTranslator
    {

        public char Translate(char charToTranslate)
        {
            if(charToTranslate=='I')
            {
                return '1';    
            }
            else
            {
                char lowerChar = Char.ToLower(charToTranslate);
                switch (lowerChar)
                {
                    case 'e':
                        return '3';
                        break;
                    case 'a':
                        return '4';
                        break;
                    case 'o':
                        return '0';
                        break;
                    case 't':
                        return '7';
                        break;
                    case 'i':
                        return '!';
                        break;
                    case 's':
                        return '$';
                        break;
                    case 'u':
                        return 'v';
                        break;
                    default:
                        return charToTranslate;
                }
            }
        }

    }
}