#!/usr/bin/perl

############### CREER
@vect = (1,2,3,4);
@tab1 = (1,2,3);
@tab2 = (0..10);

# mettre les lignes affichées par la commande "/sbin/fdisk -l"
# dans le vecteur @fdl
@fdl = `/sbin/fdisk -l`;


############### PARCOURIR
foreach (@vect){
  print;
}

############### ACCES : deux syntaxes (affiche 5)
print @tab2[5];
print $tab2[5];

###################################### vecteur non explicite ($_)
# p.ex. si boucle dans un fichier, crée un array pour chaque ligne
($elt1, $elt2, $elt3) = split (/\t/, $_);

###################################### OPERATIONS

q{
============ PUSH - POP
@liste=('a','b');
push(@liste,('c','d','e')); <==> @liste=('a','b','c','d','e')
pop(@liste);               <==> @liste=('a','b','c','d')

============ SHIFT - UNSHIFT
@liste=('c','d','e');
unshift(@liste,('a','b')); <==> @liste=('a','b','c','d','e')
shift(@liste);             <==> @liste=('b','c','d','e')

============ SORT
@liste=(100,1,2,58,225);
@tri=sort(@liste);  <==> @tri=('1','100','2','225','58')

============ REVERSE
@liste=(1,2,3,4,5);
@rev=reverse(@liste);      <==> @rev=(5,4,3,2,1)

============ CHOP
@liste=("tutu\n","toto\n");
chop(@liste);              <==>  @liste=("tutu","toto")

============ QW
@liste=("tutu","toto",'machin'); # est équivalent à
@liste = qw(tutu toto machin);   # ou même à
@liste = qw(tutu
            toto
            machin);
};

################################################## TRI
foreach (sort {$a <=> $b} @occurences) {
# trier en odre croissant (des nombres d'occurences) pour l'affichage
# l'option {$a <=> $b} fait que le tri (sort) se fait en ordre numérique
# au lieu de l'ordre lexical (alphabétique), qui est le tri par défaut
	 print;
}

