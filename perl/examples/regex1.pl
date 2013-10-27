#!/bin/perl

#############################
#							#
#		  REGEX				#
#							#
#############################


#################### BASES ##################################


#	le pattern doit correspondre exactement à la string
#	échappement, p.ex. meta caractère : \

#	/pattern/ (sans quotes !)
#	RENVOYER TRUE SI TROUVE : ~=
#	RENVOYER TRUE SI PAS TROUVE : !~
#	str match /pattern/ (match => ~= et !~ => applique la recherche à str)

if("Hello World" =~ /World/){print "=~	true \n"}
if("Hello World" !~ /NOT World/){print "!~	true \n"}

#	Dans une var : avec quotes

$pattern = "World";
if("Hello World" =~ /$pattern/){print "var1	true \n"}

#	Interpolation de variable /Hello {pattern}/
#   if("Hello World" =~ /Hello $pattern}/){print "var2	true \n"}

# Si recherche dans $_ =~ peut être omis
$_ = "Hello World";
if(/$pattern/){print "\$_	true \n"}

# Délimiteurs arbitraires : m#pattern#
if("/usr/bin/perl/" =~ m#/perl#){print "\m	true \n"}  

#-------- Ancrage : spécifier OU doit avoir lieu la reconnaissance
# ^		début de str ou de ligne
# $		fin de str ou de ligne
if("Hello World" =~ /^Hello/){print "^	true \n"}
if("Hello World" =~ /World$/){print "\$	true \n"}
if("Hello World" =~ /^Hello World$/){print "^...\$	true \n"}

#------- Ancrage par rapport au mot : \b
# \bMOT : début de mot
# MOT\b : fin de mot
# \bMOT\b : mot ( ! une fin de chaîne est considérée comme une limite de mot)

#################### CLASSE DE CARACTERES ##############################

# ENSEMBLE de chars acceptables []

#-------- OR
if("rame lame came" =~ /[rlc]ame/){print "[xyz]	true \n"}
if("oui OUI oUi ..." =~ /[oO][uU][iI]/){print "[][]	true \n"}

# $x = "O";
# if("$xTEST" =~ /[\$x]TEST/){print "[\$]	true \n"}

#------- NOT
if("NON DIGIT" =~ /[^0-9]/){print "[^x]	true \n"}

#------- INTERVALLE
if("123" =~ /[0-9]/){print "[x-y]	true \n"}



#################### ALTERNATIVES #####################################

# Ceci OU cela |
if("Hello World" =~ /Hello|World/){print "|	true \n"}


#################### REGROUPEMENT ET HIERARCHIE #######################

# () para(pluie|chute)

#################### MEMORISER LA CORRESPONDANCE ######################

# $1 $2 $3 ...
# extraction heure minute seconde
$temps = "Il est 22:30:15";
if ($temps =~ /(\d\d):(\d\d):(\d\d)/){
  # NON print 'Heures = $1, Minutes = $2, Secondes = $3';
  print 'Heures = ' . $1 . ', Minutes = ' . $2 . ', Secondes = '. $3 . "\n";
}

# \1 \2 \3 = références arrières pouvant être utilisées dans la regex

#################### REPETITION ET QUANTIFICATEURS ###################

#--------- 0,1
# a?

#--------- 0,n 
# a*

#--------- 1,n 
# a+

#--------- x à y fois
# a{x,y} 

#--------- au moins x fois
# a{x,}

#--------- exactement x fois
# a{x}


#################### MODIFICATEUR ################################ 

# //g demande à l'opérateur de correspondance de s'appliquer autant
# de fois que possible => pos permet de retracer la position

# //c


#################### SUBSTITUTION ################################ 

# s/pattern/pattern-de-substitution-sur-premiere-occurence/

# s/pattern/pattern-de-substitution-sur-toutes-occurences/g

# $1 ... directement utilisables dans l'expression de remplacement

# s///e permet d'évaluer l'expression de remplacement
# ex. s/motif/reverse $1/

# Exemple : modifier la casse
$_ = "I saw Barney with Fred";
s/(fred|barney)/\U$1/gi; # \U = uppercase (substitution) ==== /i : case insensitive (pattern)
print $_ . "\n";  
s/(fred|barney)/\L$1/gi; # \U = lowercase (substitution) ==== /i : case insensitive (pattern)
print $_ . "\n";  


#### Un exemple de programme en Perl
$message = "À l'endroit : 'camel'.\n";
print $message;
$message =~ s/endroit/envers/;
print $message;
$message =~ s/('\w+')/reverse($1)/e;
print $message;


#################### OPERATEUR DE DECOUPAGE ####################### 


#---------- découpage simple
# @field = split/separator/, $string;


# split /regex/, str

$str = "Calvin et Hobbes";
@mots = split /\s+/, $str;
print "mot 1 = ".@mots[0]." - mot 2 = ".@mots[1]." - mot 3 = ".@mots[2]."\n";

$csv = "val1,val2,  val3";
@csv = split /,\s*/, $csv;
print "v1 = ".@csv[0]." - v2 = ".@csv[1]." - v3 = ".@csv[2]."\n";

# découpage en caractères : // = vide
$abc = "abc";
@abc = split //, $abc;
print "c1 = ".@abc[0]." - c2 = ".@abc[1]." - v3 = ".@abc[2]."\n";

# découpage en parties : /(/)/ = regroupement : produit AUSSI les groupes reconnus
$part = "/usr/bin";
@part = split m'(/)', $part;
print "p1 = ".@part[0]." - p2 = ".@part[1]." - p3 = ".@part[2]." - p4 = ".@part[3]." - p5 = ".@part[4]."\n";

#----------- opposé de split : join
