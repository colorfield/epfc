var set1 = [{id:'a', weight:2}];
var set2 = [{id:'a', weight:2},{id:'b', weight:2}];
var set3 = [{id:'a', weight:2},{id:'b', weight:2},{id:'c', weight:3}];
var set4 = [{id:'a', weight:2},{id:'b', weight:2},{id:'c', weight:3},{id:'d', weight:3}];
var set5 = [{id:'a', weight:2},{id:'b', weight:2},{id:'c', weight:3},{id:'d', weight:3},{id:'e', weight:4}];
var set6 = [{id:'a', weight:2},{id:'b', weight:2},{id:'c', weight:3},{id:'d', weight:3},{id:'e', weight:4},{id:'f', weight:3}];

var groups = new Array();

// need a tree data structure + recursive algorithm






//--------------
//--------------


/**
 * Cuts the first element of the set (group of 1 element)
 * and returns the 2 resulting groups
 */
function cut_first(set){
	writeResult('Cut first');
	var nested_groups = new Array();
	nested_groups[0] = new Array();
	nested_groups[1] = new Array();

	nested_groups[0].push(set[0]);
	for (var i = 1; i < set.length; i++) { 
		nested_groups[1].push(set[i]);
	}
	return nested_groups;
}

/**
 * Cuts the last element of the set (group of 1 element)
 * and returns the 2 resulting groups
 */
function cut_last(set){
	writeResult('Cut last');	
	var nested_groups = new Array();
	nested_groups[0] = new Array();
	nested_groups[1] = new Array();

	nested_groups[1].push(set[set.length - 1]);
	for (var i = 0; i < set.length - 1; i++) { 
		nested_groups[0].push(set[i]);
	}
	return nested_groups;
}

/**
 * Appends outputs on the result div
 */
function writeResult(str){
	var curStr = $('#result').html();
	str = curStr + "<br>" + str;
	$('#result').html(str);
}


/**
 * Cut a set into groups
 */
function cut(set){
	writeResult("Set length = " + set.length);
	switch(set.length){
		case 1:
			writeResult("Calculate weight for set 1");
			break;
		case 2:
			writeResult("Calculate weight for set 2");
			break;
		case 3:
			writeResult("Do combinations for set 3, and calculate results");
			groups[0] = cut_first(set);
			groups[1] = cut_last(set);
			for (var i = 0; i < groups.length; i++) { 
				console.log(groups[i]);
				for (var j = 0; j < groups[i].length; j++) {
					cut(groups[i][j]); 
				}
			}
			break;

	}
}


// main
$( document ).ready(function() {
	cut(set3);
});