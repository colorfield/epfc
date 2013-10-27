#!/usr/bin/perl
  	
#$ligne = <STDIN>;
#print '$ligne = ' . $ligne;

## ne pas utiliser : prompt => print '<STDIN> = ' . <STDIN>;
## ne retoune rien : print '$_ = ' . $_;

# variable scalaire fourre-tout nommée $_ ($ souligné)
# comme résultat par défaut d'un certain nombre d'instructions. 
# C'est notamment le cas avec la lecture sur l'entrée standard : 
#
#    while (<STDIN>)         <==>  while ($_ = <STDIN>)
#    {                       <==>  {
#	chop;            		 <==>     chop($_);
#    }                       <==>  }

# while ($_ = <STDIN>)
# {
#  chop($_);
# }

@vecteur=(1,2,3,4,5);
# foreach (@liste)     <==>   foreach $_ (@liste)
# {                    <==>   {
#   print ;            <==>     print $_;
# }                    <==>   }

foreach $_ (@vecteur)
{
  print $_;
}