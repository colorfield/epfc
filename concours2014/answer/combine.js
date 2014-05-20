var set1 = [{id:'a', weight:2}];
var set2 = [{id:'a', weight:2},{id:'b', weight:2}];
var set3 = [{id:'a', weight:2},{id:'b', weight:2},{id:'c', weight:3}];
var set4 = [{id:'a', weight:2},{id:'b', weight:2},{id:'c', weight:3},{id:'d', weight:3}];
var set5 = [{id:'a', weight:2},{id:'b', weight:2},{id:'c', weight:3},{id:'d', weight:3},{id:'e', weight:4}];
var set6 = [{id:'a', weight:2},{id:'b', weight:2},{id:'c', weight:3},{id:'d', weight:3},{id:'e', weight:4},{id:'f', weight:3}];

var groups = new Array();

// https://www.google.be/search?q=algorithm+to+generate+subsets+of+a+set&oq=algorithm+generate+subsets+
// http://stackoverflow.com/tags/partition-problem/hot

//--------------------------------------------
// Backtracking test of subsets generation
// http://www.cse.ohio-state.edu/~gurari/course/cis680/cis680Ch19.html
// http://stackoverflow.com/questions/5824566/recursive-backtracking-algorithm-for-solving-the-partitioning-problem#_=_
//--------------------------------------------

var set = ['a','b','c','d','e'];
var current_words = [];
var v = new Array(); // no type, can handle boolean or letters with the tests below
var n = 3; // number of combinations

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
        current_words.push(set[s]);
        if($.inArray(set[s], current_words)){
          console.log('Break');
          current_words = []; 
        }
        words(i+1);
        
    }
  }
}

//--------------
// Iterative
//--------------


// http://stackoverflow.com/questions/18201617/generate-all-subsets-of-a-set-in-javascript
function combine_v1(input){
  var result, mask, total = Math.pow(2, input.length);
  for(mask = 0; mask < total; mask++){ //O(2^n)
      result = [];
      i = input.length - 1; //O(n)
      do{
          if( (mask & (1 << i)) !== 0){
              result.push(input[i]);
          }
      }while(i--);
      console.log(result);
  }
}

// http://stackoverflow.com/questions/5752002/find-all-possible-subset-combos-in-an-array
var combine_v2 = function(a, min) {
    var fn = function(n, src, got, all) {
        if (n == 0) {
            if (got.length > 0) {
                all[all.length] = got;
            }
            return;
        }
        for (var j = 0; j < src.length; j++) {
            fn(n - 1, src.slice(j + 1), got.concat([src[j]]), all);
        }
        return;
    }
    var all = [];
    for (var i = min; i < a.length; i++) {
        fn(i, a, [], all);
    }
    all.push(a);
    return all;
}

//--------------
//--------------


// need a tree data structure + recursive algorithm
// see tree.js


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
	//binary_words(0);
  	//words(0);
  	//combine_v1(set);
  	//var subsets = combine_v2(set, 3);
    //console.log(subsets);
});