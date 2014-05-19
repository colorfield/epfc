//--------------------------------------------
//
// Backtracking test of subsets generation
//
//--------------------------------------------

var set = ['a','b','c','d','e'];
var v = new Array(); // no type, can handle boolean or letters with the tests below
var n = 5; // number of combinations

/**
 * Displays the combination result
 */
function displayWords(){
  var output = '';
  for (var i = 0; i < n; ++i) {
    output += v[i] + ', ';
  }
  console.log(output);
}

/**
 * Combines sets of booleans
 */
function binary_words(i){
  if(parseInt(i) == parseInt(n)){
    displayWords();
  }else{
    v[i] = true;
    binary_words(i+1);
    v[i] = false;
    binary_words(i+1);
  }
}

/**
 * Combines sets of letters
 */
function words(i){
  if(parseInt(i) == parseInt(n)){
    displayWords();
  }else{
    for (var s = 0; s < set.length; ++s) {
        v[i] = set[s];
        words(i+1);  
    }
  }
}


/**
 * Generates subsets
 */
function generateSubsets(){
  //binary_words(0);
  words(0);
}


//----------------------------------------

/**
 * Resolves partition problem
 */
function resolvePartition(disk){
  var subsets = generateSubsets();
}

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
 * @TODO needs MVC refactoring
 */
function Disk(){
  this.size = 0;
  this.nCuts =  0;
  this.limits = new Array();
  this.partitions = new Array();
  // default demo values
  this.defaultSize = 10;
  this.defaultNCuts = 3;
  this.defaultLimits = [2,4,7]; // assumes that length matches defaultNCuts
  this.init = true;

  this.maxSize = 0;

  // @TODO set main events handlers on the constructor

  /**
   * Populates disk properties 
   * from input text on the view or from default values
   */
  this.readDiskPropertiesFromInput = function(){
    // input 1: disk size
    if($("#diskInput #diskSize").val() != ''){
      this.size = $("#diskInput #diskSize").val();
    }else{
      this.size = this.defaultSize;  
      // reflect default on the view
      $("#diskInput #diskSize").val(this.defaultSize);
    }
    
    // input 2: partitions cuts on the disk
    if($("#diskInput #diskNCuts").val() != ''){
      this.nCuts = $("#diskInput #diskNCuts").val();
    }else{
      this.nCuts = this.defaultNCuts;
      // reflect default on the view
      $("#diskInput #diskNCuts").val(this.defaultNCuts);
    }
  }

  /**
   * Populates partitions limit properties 
   * from input text on the view or from default values
   */
  this.readPartitionsPropertiesFromInput = function(){
    var parent = this; // need this to reference in .each context
    // input 3: partitions limits on the disk
    console.log("Limits");
    console.log(this.limits);
    $("#diskPartitionsLimits input.diskLimits").each(function(index) {
      if($(this).val() != ''){
        parent.limits.push($(this).val());  
      }else{
        if(parent.defaultLimits[index] != undefined){
          parent.limits.push(parent.defaultLimits[index]);
            // reflect default on the view
          $(this).val(parent.defaultLimits[index]);  
        }else{
          // @TODO random value
        }
      }
    });
    console.log(this.limits);
  }

  /**
   * Create partitions inputs view from the nCuts property
   */
  this.createPartitionLimitsView = function(){
    var html = '';
    for (var i = 1; i <= this.nCuts; i++) { 
      html += '<label for="diskLimit'+i+'">Limit '+i+'</label> <input type="number" id="diskLimit'+i+'" class="diskLimits" name="diskLimit'+i+'" value="" min="1" max="1000"><br>';
    }
    $('#diskPartitionsLimits').html(html);
  }

  /**
   * Callback function on view change
   * refreshes data and view (controller)
   */
  this.refresh = function(){
    // do not trigger if values did not changed
    //if(this.init || $("#diskInput #diskSize").val() != this.size || $("#diskInput #diskNCuts").val() != this.nCuts){
      //alert("Refresh");
      this.init = false;
      this.initProperties();
      this.readDiskPropertiesFromInput();
      this.createPartitionLimitsView();
      // @TODO do not trigger if limits did not changed
      this.readPartitionsPropertiesFromInput();
      this.createPartitionsModel();
      this.renderDiskView();
      this.renderPartitionsView();
      resolvePartition();

    //}
  }

  /**
   * Renders the disk view
   */
  this.renderDiskView = function(){
    var html = '[ Disk size = ' + this.size + ' - Number of partitions = ' + (parseInt(this.nCuts)+1) + ' ]';
    $("#diskResult").html(html);
  }


  /**
   * Populates the max size value
   */
  this.getMaxPartitionSize = function(){
    for(i in this.partitions){
      if(this.partitions[i].size > this.maxSize){
        this.maxSize = this.partitions[i].size;
      }
    }
  }

  /**
   * Renders the partitions view
   */
  this.renderPartitionsView = function(){
    var html = '<table class="table">';
    for(p in this.partitions){
      html += '<tr>';
      for (var i = 1; i <= this.maxSize; i++) {
        if(i <= this.partitions[p].size){
          html += '<td>1</td>';
        }else{
          html += '<td>0</td>';
        }
      }
    }
    html += '</table>';
    $("#partitionsResult").html(html);
  }

  /**
   * Empties properties
   */
  this.initProperties = function(){
    this.size = 0;
    this.nCuts =  0;
    this.limits = [];
    this.partitions = [];

    this.maxSize = 0;
  }


  /**
   * Creates partitions objects an a disk object
   */
  this.createPartitionsModel = function(){
    // creates partitions and calculate each size
    for (var limitKey in this.limits){
     console.log(this.limits[limitKey]);
     var p = new Partition();
     // exception 1 : is first partition
     if(limitKey == 0){
      p.isFirst = true;
      p.size = this.limits[limitKey];
      p.limits = [0, this.limits[limitKey]];
      //console.log('is FIRST');
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
    //console.log('is LAST');
    this.partitions.push(p);

    this.getMaxPartitionSize();

    console.log(this.partitions);
  }
};


// main
$( document ).ready(function() {

  var disk = new Disk();
 
  $("#diskInput #diskSize").change(function() {
     disk.refresh();
  }).trigger('change'); // to handle default values

  // @todo
  /*
  $("#diskInput #diskNCuts").change(function() {
     disk.refresh();
  }).trigger('change'); // to handle default values
  */
  /*
  // using on (old "live") for js created DOM elements
  $("#diskPartitionsLimits input.diskLimits").on("input", function() {
     disk.refresh();
  }).trigger('change'); // to handle default values
  */

});