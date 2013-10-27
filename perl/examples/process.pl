#!/usr/bin/perl

#################################
#								
#	PROCESS					
#								
#################################


####### KILL ####################
# tuer un process lié à un user
system("/usr/bin/killall -u $user $proc");


####### FORK ####################

# duplication de process (même programme, mêmes propriétés)
# => peut exécuter des choses différentes

###### process père => non bloqué par le programme auxiliaire ###########################
if ($pid = fork){	
   # continue exécution programme principal
   $in = <STDIN>;
   # peut tuer les process fils (et aussi les descendants, 
   # sauf si démon se détachant de son créateur 
   # 3 process en jeu :	-duplication programme principal (fils créé par fork)
   #			-shell bash lançant le 3e
   #			-le 3e

   # trouver le fils de $pid (petit-fils)
   $pidf = `/bin/ps h --ppid $pid`; 
   $pidf =~ s/\s*(\d+)\s.*/$1/; 
   chomp $pidf; 

   # trouver les fils de $pidf = l'arrière petit fils = le fils du petit fils
   $pidff = `/bin/ps h --ppid $pidf`; 
   $pidff =~ s/\s*(\d+)\s.*/$1/; 
   chomp $pidff;

   ##### tuer tous les process
   system("/usr/bin/kill -9 $pid"); 
   system("/usr/bin/kill -9 $pidf"); 
   system("/usr/bin/kill -9 $pidff");   

 ###### process fils, ne reçoit pas de pid => bloqué par p.a. #################################
}else{			
   # (process fils) exécute le programme auxiliaire 
   system("/usr/bin/..."); 
}
