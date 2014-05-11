/**
 * Partition class
 */
function Partition(){
	this.size = 0;
	this.isFirst = false;
	this.isLast = false;
	this.limits = [];
}

/**
 * Disk class
 */
function Disk(){
  this.size = 0;
  this.nCuts =  0;
  this.limits = [];
  this.partitions = [];

  /**
   * Create partitions objects an a disk object
   */
  this.createPartitions = function(){
    // create partitions and calculate each size
    for (var limitKey in this.limits){
     console.log(this.limits[limitKey]);
     var p = new Partition();
     // exception 1 : is first partition
     if(limitKey == 0){
      p.isFirst = true;
      p.size = this.limits[limitKey];
      p.limits = [0, this.limits[limitKey]];
      console.log('is FIRST');
     // in between, do nothing, initialized to false
     }else{
      p.size = this.limits[limitKey] - this.limits[limitKey - 1];
      p.limits = [this.limits[limitKey - 1], this.limits[limitKey]];
     }
     this.partitions.push(p);
    }

    // exception 2 : is last partition
    var p = new Partition();
    p.isLast = true;
    p.size = this.size - this.limits[this.limits.length - 1];
    p.limits = [this.limits[limitKey], this.size - 1];
    console.log('is LAST');
    this.partitions.push(p);

    console.log(this.partitions);
  }
};

// main
$( document ).ready(function() {
  // input 1: disk size
  var disk = new Disk();
  disk.size = 10;
  // input 2: partitions cuts on the disk
  disk.nCuts = 3;
  // input 3: partitions limits on the disk
  disk.limits = [2,4,7];

  disk.createPartitions();

  $("#result").text('Disk size = ' + disk.size);
  
  

});