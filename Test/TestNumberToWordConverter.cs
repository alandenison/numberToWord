using System.Collections.Generic;
using Xunit;
using NumberToWordConverter.Objects;

namespace NumberWordConverter
{
  public class ConverteTest
  {
    [Fact]
    public void Number_ForZero_ReturnWord()
    {
      Converter converter = new Converter(0);
      Assert.Equal("zero", converter.FindNumber());
    }
    [Fact]
    public void Number_ForThirtyOne_ReturnWord()
    {
      Converter converter = new Converter(19);
      Assert.Equal("thirtyone", converter.FindNumber());
    }
    [Fact]
    public void Number_ForOneHundredThirtyOne_ReturnWord()
    {
      Converter converter = new Converter(814);
      Assert.Equal("onehundredthirtyone", converter.FindNumber());
    }
    public void Number_Foronehundredtwentythousandnineteen_ReturnWord()
    {
      Converter converter = new Converter(120019);
      Assert.Equal("onehundredtwentythousandnineteen", converter.FindNumber());
    }
  }
}
