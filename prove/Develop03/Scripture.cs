using System;
public class Scripture
{

  private Reference _reference;
  private List<Word> _words = new List<Word>();

  public Scripture(Reference reference, string text)
  {

    _reference = reference;
    string[] palabras = text.Split(" ");
    foreach (string palabra in palabras)
    {
      _words.Add(new Word(palabra));
    }
  }

  public void HideRandomWords(int numbertoHide)
  {

    int i = 0;
    Random random = new Random();

    for (i = 0; i < numbertoHide; i++)
    {
      _words[random.Next(_words.Count)].Hide();
    }

  }

  public string GetDisplayText()
  {

    string text = "";
    text += _reference.GetDisplayText();
    text += "\n";
    text += "\n";

    foreach (Word w in _words)
    {
      text += w.GetDisplayText();
      text += " ";
    }
    return text;

  }

  public bool IscompletelyHidden()
  {

    foreach (Word w in _words)
    {
      if (w.IsHidden() == false)
      {
        return false;
      }
    }
    return true;
  }





}