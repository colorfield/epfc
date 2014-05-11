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
    $("#diskPartitionsLimits input.diskLimits").each(function(index) {
      if($(this).val() != ''){
        this.limits.push($(this).val());  
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
  }

  /**
   * Create partitions inputs view from the nCuts property
   */
  this.createPartitionLimitsView = function(){
    var html = '';
    for (var i = 1; i <= this.nCuts; i++) { 
      console.log("I = " + i);
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
    if(this.init || $("#diskInput #diskSize").val() != this.size || $("#diskInput #diskNCuts").val() != this.nCuts){
      this.init = false;
      this.initProperties();
      this.readDiskPropertiesFromInput();
      this.createPartitionLimitsView();
      // @TODO do not trigger if limits did not changed
      this.readPartitionsPropertiesFromInput();
      this.createPartitionsModel();
      this.renderDiskView();
      this.renderPartitionsView();  
    }
  }

  /**
   * Renders the disk view
   */
  this.renderDiskView = function(){
    $("#diskResult").text('[ Disk size = ' + this.size + ' - Number of partitions = ' + (parseInt(this.nCuts)+1) + ' ]');
  }

  /**
   * Renders the partitions view
   */
  this.renderPartitionsView = function(){
    $("#partitionsResult").text('todo');
  }

  /**
   * Empties properties
   */
  this.initProperties = function(){
    this.size = 0;
    this.nCuts =  0;
    this.limits = [];
    this.partitions = [];
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

  var disk = new Disk();
 
  $("#diskInput #diskSize").change(function() {
     disk.refresh();
  }).trigger('change'); // to handle default values

  $("#diskInput #diskNCuts").change(function() {
     disk.refresh();
  }).trigger('change'); // to handle default values
  
  $("#diskInput .diskLimits").change(function() {
     disk.refresh();
  }).trigger('change'); // to handle default values


});