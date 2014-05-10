// Partition class
function Partition(){
	this.size = 0;
	this.isFirst = false;
	this.isLast = false;
	this.limits = [];
}

// disk object
var disk = {
    size: 10,
    nPartitions: 3,
    limits: [],
    partitions: []
};

// main
$( document ).ready(function() {
  // input = disk size and limits
  $("#result").text('disk size = ' + disk.size);
  disk.limits = [2,4,7];

  var cluster = 0;
  // create partitions and calculate each size
  for (var limitKey in disk.limits){
   console.log(disk.limits[limitKey]);
   var p = new Partition();
   // exception 1 : is first partition
   if(limitKey == 0){
   	p.isFirst = true;
   	p.size = disk.limits[limitKey];
   	cluster += p.size;
   	console.log('is FIRST');
   // in between, do nothing, initialized to false
   }else{
   	p.size = disk.limits[limitKey] - disk.limits[limitKey - 1];
   }
   
   disk.partitions.push(p);

  }

  // exception 2 : is last partition
  var p = new Partition();
  p.isLast = true;
  p.size = disk.size - disk.limits[disk.limits.length - 1];
  console.log('is LAST');
  disk.partitions.push(p);

  console.log(disk.partitions);

});