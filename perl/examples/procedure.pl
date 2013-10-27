#!/usr/bin/perl

$param1 = shift;
$param2 = shift;

&afficher($param1, $param2);
&afficher($param2, $param1);

sub afficher {
	my ($arg1, $arg2) = @_;
	  print "\n";
	  print "\$arg1=$arg1";
	  print "\n";
	  print "\$arg2=$arg2";
	  print "\n";
	  print "\n";
}

#############################################
# calcul d'un max sur base de n params
$maximum = &max(3, 5, 10, 4, 6);
sub max {
  my($max_so_far) = shift @_;
  foreach (@_) {
    if ($_ > $max_so_far) {
      $max_so_far = $_;
    }
  }
  $max_so_far;
}

