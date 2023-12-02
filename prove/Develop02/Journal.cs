using System;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();
  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }
  public void DisplayAll()
  {
    foreach (Entry e in _entries)
    {
      e.Display();
    }
  }
  public void SaveToFile(string file)
  {
    string filetext = "";

    foreach (Entry e in _entries)
    {
      filetext += e._date;
      filetext += e._promptText;
      filetext += e._entryText;
    }
    File.WriteAllText("entry.txt", filetext);
  }
  public void LoadFromFile(string file)
  {
    //if(){
  }


}





