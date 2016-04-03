module Kickoff

open CommonLatex
open LatexDefinition
open CodeDefinitionLambda
open Interpreter

let slides =
  [
    Section( @"Introduction")
    SubSection("Overview")
    ItemsBlock
      [
        ! @"Looking back"
        ! @"A short overview of the project"
        ! @"Survival tips"
      ]

    Section( @"Looking back")
    SubSection("Let's take a second to look back")
    VerticalStack
      [
        TextBlock @"You are more than halfway through the first year."
        Pause
        TextBlock @"The worst is over."
        Pause
        TextBlock @"You are on your way to becoming true professionals, and we could not be happier about it."
      ]

    SubSection("What have you really learned?")
    ItemsBlock
      [
        ! @"You can now program\footnote{for a small enough value of \textit{programming}}"
        ! @"You can work in teams to compose your skills"
      ]

    TextBlock @"You can build simple software products that work locally and in isolation (standalone applications)."

    SubSection("What next?")
    TextBlock @"Let's add a stepping stone to what you are learning."

    Section(@"A short overview of the project")
    SubSection("Motivation")
    VerticalStack
      [
        TextBlock @"We live in a world where data is completely pervasive. Everything, everywhere, becomes data somehow."
        Pause
        TextBlock @"But what do we do with billions of numbers in a table? How do we make sense of it?"
        Pause
        TextBlock @"We \textbf{make it alive}."
        Pause
        TextBlock @"We \textbf{draw it}."
      ]

    SubSection("General idea")
    VerticalStack
      [
        TextBlock @"In this project, you will..."

        ItemsBlock
          [
            ! @"...build an application made up of multiple, separate components;"
            ! @"...gather, process, store, and visualise data on a GUI."
          ]
      ]

    SubSection("About the data")
    VerticalStack
      [
        TextBlock @"You will find data about the city of Rotterdam"
        Pause
        TextBlock @"The choice of data will be based on interest and the possiblity to generate useful information from it."
      ]

    VerticalStack
      [
        TextBlock @"The data will be studied and analysed into an ERD and a physical model"
        Pause
        TextBlock @"The data will then be automatically processed and saved on a database\footnote{reflecting the documents above. Duh.}"
      ]

    SubSection("About the application")
    VerticalStack
      [
        TextBlock @"An application will connect to the database"
        Pause
        TextBlock @"The connection may be anything you like: manual (hardcore), or mediated by an object-relational-mapping (ORM)\footnote{Entity framework + LINQ, hibernate, etc.}"
      ]

    VerticalStack
      [
        TextBlock @"A series of queries will get data from the database into the application"
        Pause
        TextBlock @"You will then process the data, and visualise the results"
      ]

    SubSection("About visualisation")
    VerticalStack
      [
        TextBlock @"Visualisation will be the fundamental aspect of the work"
        Pause
        TextBlock @"Visualisation\footnote{If you put everything on a map, then it gets pretty, understandable, and you get lots of points.} makes it possible to understand and make sense of the data"
        Pause
        TextBlock @"Make sure to include enough information to make it clear how the visualisation is to be understood"
      ]

    Section( @"Survival tips")
    SubSection("Issues")
    TextBlock @"Working together on a project is not always so simple!"

    ItemsBlock
      [
        ! @"Setting up structures"
        ! @"Writing reasonable code"
        ! @"Collaborating via source control"
      ]

    SubSection "Setting up structures"
    VerticalStack
      [
        TextBlock @"Code is like violence: if it does not work, write some more?"
        Pause
        TextBlock @"Actually, this is not true!"
      ]

    VerticalStack
      [
        TextBlock @"Like any other complex activity, usage of brains is highly recommended"
        Pause
        TextBlock @"This translates to \textit{think before you act}"
      ]

    VerticalStack
      [
        TextBlock @"Thinking, in this case, refers to deliberately architecting everything"
        Pause
        TextBlock @"UML-like structures help: \textbf{not as a formal tool, but as a thinking aid}"
        Pause
        TextBlock @"It does not matter if your diagrams are perfect according to the standard: what matters is that they allow you to explore the domain of possible solutions."
      ]

    Figure("uml_by_hand.JPG", 0.6)

    VerticalStack
      [
        TextBlock @"Biggest goal: identify important blocks of functionality, and isolate them"
        Pause
        TextBlock @"Divide-and-conquer approach"
        Pause
        TextBlock @"The smallest blocks of functionality are classes"
      ]

    SubSection "Small? Classes? Lol!"
    VerticalStack
      [
        TextBlock @"We are aware that the average student could potentially just write a single, big class doing everything"
        Pause
        TextBlock @"This would be disastrous for architecture, maintainability, and testing"
        Pause
        TextBlock @"Worst of all: collaboration on such a monolithic entity becomes then impossible"
        Pause
        TextBlock @"You are required to write short classes that only cover one scenario"
      ]

    TextBlock @"Complex functionality comes from composition and polymorphism"

    SubSection "Using GitHub"
    VerticalStack
      [
        TextBlock @"Life is too short to learn to use the command line"
        Pause
        TextBlock @"Use the GUI's: \textit{GitHub desktop}, or the integration of GitHub in IDE's like Visual Studio and IntelliJ"
      ]

    VerticalStack
      [
        TextBlock @"Life is too short to merge commits"
        Pause
        TextBlock @"Small files, and logical and short classes, already prevent a lot of conflicts"
        Pause
        TextBlock @"Ensure that each file has exactly \textbf{one and only one owner}"
      ]

    VerticalStack
      [
        TextBlock @"Commit often (once a day)"
        Pause
        TextBlock @"Waiting for days is a sure recipe for disaster"
        Pause
        TextBlock @"Solve any commit conflicts right away, before going home"
      ]

    Section( @"Conclusion")
    SubSection("Closing up")
    ItemsBlock
      [
        ! @"You have achieved a lot in the last months"
        ! @"It is now time to impress us: build a modern data-heavy graphical application"
        ! @"Be smart about your work, control complexity, and work together with discipline"
      ]
  ]
