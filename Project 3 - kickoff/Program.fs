open Compile

[<EntryPoint>]
let main argv = 
  do batchProcess LatexDefinition.generatePresentation Kickoff.slides "Project_3_kickoff" @"The project team" "Project 3 kickoff" true true

  0
