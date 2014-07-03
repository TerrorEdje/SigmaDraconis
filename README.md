#SigmaDraconis

Project to build a new website for SigmaDraconis in asp.net and c#

##Information

1. [GitFlow](http://danielkummer.github.io/git-flow-cheatsheet/) - Basic explation of how we are going to use GitFlow (purely theory, SourceTree has inbuild tools for this).
2. [SourceTree](http://www.sourcetreeapp.com/) - Application that uses the GitHub protocol and with inbuild GitFlow.
3. [Haroopad](http://pad.haroopress.com/user.html) - For those wanting to edit .md files (MarkDown, free tool and makes it easy. Best to use this for documents we share on GitHub.

##Coding guidelines
It are just guidelines... but a good idea to use. If you have something to add here, please let me know! (Or just English mistakes)

####Terminology
* **camelCase**: Names starting with small letter, every next word with a capital letter.
* **PascalCase**: Names starting with a capital letter, every next word with a capital letter.

###1 Files and directorys
####1.1 Classes
Classes each get their own file, names of the class should be the same as the file. Use PascalCase for the name and it should ofcourse end on .cs.
####1.2 Directory structure
Keep the directorys structured, move files when necessary. Keep the namespaces the same as the folders.

###2 Comments
Use comments when you think necessary for others to read it. If you give methods a good name, you don't need to use comments (in my opinion).

###3 Global style
####3.1 Spaces, tabs and braces
Use the standard style of Visual Studio, to prevent merge conflicts it's best if you do ALK+K+D to format the code.
####3.2 Sexy Code
Code has to be written in a way it looks like the perfect girlfriend; long and slender. Don't make the code too wide, but preferebly continue on the next line.
####3.3 Repeat
Never repeat your code. Write a second method to prevent repeated functionality.

###4 Names
|Kind|Capitalization|Part of speech|Remark|
|----|--------------|--------------|------|
|Class|PascalCase|Nuon||
|Interface|PascalCase|Nuon|Capital I followed by PascalCase|
|Enum type|PascalCase|Nuon|Noun is always singular|
|Enum value|PascalCase|Nuon||
|Methods|PascalCase|Verb||
|Namespace|PascalCase|Nuon||
|Private Field|camelCase|Nuon||
|Property|PascalCase|Nuon||
|Parameter|camelCase|Nuon||
|Constants|PascalCase|Nuon||
###5 Fixed values
Place non changing values always in a const field. This way it will be clear when something is a non changing value. Example: Height or PlayersCount.

##Example class
```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpeProject
{
    enum Colors
    {
        Blue,
        Yellow,
        Red
    };
    class Something
    {
        List<int> list;

        public Something()
        {

        }
        public void DoSomething(int something)
        {
            foreach (int item in list)
            {
                PerformIteration();
            }
        }
        public void PerformIteration()
        {
            Sometimes();
            foreach(int item in list)
            {
                Often();
                if (item == null)
                {
                    DoIt();
                }
            }
        }
        public void Often()
        {
            Console.WriteLine("Often");
        }
        public void DoIt()
        {
            Colors color = Colors.Blue;
            switch (color)
            {
                case Colors.Blue:
                    Console.WriteLine("Blue");
                    break;
                case Colors.Red:
                    Console.WriteLine("Red");
                    break;
                case Colors.Yellow:
                    Console.WriteLine("Yellow");
                    break;
                default:
                    throw new System.ArgumentException("color has wrong value");
            }
        }

        public void Sometimes()
        {
            Console.WriteLine("Sometimes");
        }
    }
}
```
