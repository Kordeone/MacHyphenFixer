// See https://aka.ms/new-console-template for more information


Console.WriteLine(" X    Azoona doros kone moj      X ");
Console.WriteLine("\nYe inter bezan mahze rezaye khoda");

Console.ReadLine();

#region WorksForText

// var here = Environment.CurrentDirectory;
// string txt = File.ReadAllText(here + "/ss.txt");
//
// var newTxt = txt.Replace("¬", "‌");
//
//
// File.WriteAllText(here + "/ss - fixed.txt", newTxt);

#endregion


#region InWord

var files = Directory.GetFiles(Environment.CurrentDirectory + "/files");

 if (files.Where(f => f.Contains(".txt")).ToList().Count > 1)
 {
     Console.WriteLine("MORE THAN TWO TEXT FILES IS NOT ALLOWED");
 }
 else if(files.Where(f => f.Contains(".txt")).ToList().Count == 0)
 {
     Console.WriteLine("AMME JANAM RO FIX KONAM?");
 }
 else
 {
    
     var docPath = files.FirstOrDefault(f => f.Contains(".txt"));
     var newDocPath = docPath.Replace(".txt"," - fixed.txt");

     string txt = File.ReadAllText(docPath);

     var newTxt = txt.Replace("¬", "‌");


     File.WriteAllText(newDocPath, newTxt);
 }

#endregion
Console.ReadLine();

