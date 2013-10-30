#!/usr/bin/perl

# Reverse assignation expressions on a file, line per line
# Reads a file from the command line and outputs results on 'output.txt' file.

# Example 
# Input : 
# $var1 = $var2
# $var3 = $var4
# Output :
# $var2 = $var1
# $var4 = $var3

my $input_file = shift; # take first parameter from the command line
if($input_file eq ""){
  print "No input file provided\n";
}else{
  open(my $input_handle, '<', $input_file)
    or die "Unable to open file $!"; 

  my $output_file = "output.txt";
  open(my $output_handle, ">", $output_file)
    or die "Unable to open file $!";

   while(my $line=<$input_handle>){
   	  chomp $line;
	  my @values = split('=', $line); 
	  $reverted_line = @values[1] . " = " . @values[0]; 
	  print $reverted_line . "\n";
	  print $output_handle $reverted_line . "\n";
   }

   close($output_handle)
     or warn "Unable to close the file handle: $!";
   close($input_handle)
     or warn "Unable to close the file handle: $!";

}