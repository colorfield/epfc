/*
Programme de démo des E/S pour le concours de programmation EPFC 2014.
Vous ne devez pas modifier le format de ces E/S
(si ce n'est enlever le message "DemoIO..."!)

Ce programme lit deux nombres length et nbCuts sur les 2 premières lignes de
l'entrée standard. Il lit ensuite nbCuts nombres (un par ligne) et écrit sur
la sortie standard le texte "Somme : " suivi de la somme de tous les nombres
lus et d'un saut de ligne.
*/

object DemoIO {
  def main(args : Array[String]) = {
    println("DemoIO Scala")
    val length = readInt()
    val nbCuts = readInt()
    var somme = 0
    for(k <- 1 to nbCuts) {
      val cutPlaces = readInt()
      somme += cutPlaces
    }
    println("Somme : " + (length + nbCuts + somme))
  }  
}

