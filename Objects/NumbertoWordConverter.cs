using System;
using System.Collections.Generic;

namespace NumberToWordConverter.Objects
{
  public class Converter
  {
    private static Dictionary<int, string> numberWordTable = new Dictionary<int, string> ()
    {
    {0, ""},
    {1, "one"},
    {2, "two"},
    {3, "three"},
    {4, "four"},
    {5, "five"},
    {6, "six"},
    {7, "seven"},
    {8, "eight"},
    {9, "nine"},
    {10, "ten"},
    {11, "eleven"},
    {12, "twelve"},
    {13, "thirteen"},
    {14, "fourteen"},
    {15, "fifteen"},
    {16, "sixteen"},
    {17, "seventeen"},
    {18, "eighteen"},
    {19, "nineteen"},
    {20, "twenty"},
    {30, "thirty"},
    {40, "fourty"},
    {50, "fifty"},
    {60, "sixty"},
    {70, "seventy"},
    {80, "eighty"},
    {90, "ninety"}


  };

  private int _userInput;
  private string numberToWord;
  public Converter(int aNumber)
  {
    _userInput = aNumber;
  }


  public string HundredWord()
  {
    if(_userInput <= 20)
    {
    return numberToWord = numberWordTable[_userInput];
    }
    else if (_userInput > 20 && _userInput <= 99)
    {
      return numberToWord = numberWordTable[_userInput-(_userInput % 10)] + numberWordTable[_userInput % 10];
    }
    else if (_userInput > 99 && _userInput < 1000 && (_userInput % 100) > 20)
    {
      int hundreds = (_userInput - (_userInput % 100));
      return numberToWord = numberWordTable[(_userInput - (_userInput % 100))/100] + "hundred" + numberWordTable[_userInput - hundreds -(_userInput % 10)] + numberWordTable[_userInput % 10];
    }
    else if (_userInput > 99 && _userInput <1000)
    {
      int hundreds = (_userInput - (_userInput % 100));
      return numberToWord = numberWordTable[(_userInput - (_userInput % 100))/100] + "hundred" + numberWordTable[_userInput - hundreds];
    }
    else
    {
      return numberToWord = "hi";
    }
  }
  public string FindNumber()
  {
    if (_userInput.ToString().Length < 4)
    {
      HundredWord();
      return numberToWord;
    }
    else if (_userInput.ToString().Length > 4)
    {
      int thousands = (_userInput - (_userInput % 1000))/1000;
      int hundredOfThousand = _userInput % 1000;
      thousands.HundredWord() + "thousand" + hundredOfThousand.HundredWord();
      return numberToWord;

    }
    else
    {
      return numberToWord="hello";
    }
  }

}
}
