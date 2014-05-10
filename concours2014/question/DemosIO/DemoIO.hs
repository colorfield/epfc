{-
Programme de démo des E/S pour le concours de programmation EPFC 2014.
Vous ne devez pas modifier le format de ces E/S
(si ce n'est enlever le message "DemoIO..."!)

Ce programme lit deux nombres length et nbCuts sur les 2 premières lignes de
l'entrée standard. Il lit ensuite nbCuts nombres (un par ligne) et écrit sur
la sortie standard le texte "Somme : " suivi de la somme de tous les nombres
lus et d'un saut de ligne.
-}

main = do
  putStrLn "DemoIO Haskell"
  length  <- readLn   
  nbCuts  <- readLn   
  ls <- sequence (take nbCuts (repeat readLn))
  putStrLn ("Somme : " ++ show(length + nbCuts + sum ls))
