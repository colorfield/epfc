// main
$( document ).ready(function() {

	/**
	 * Tests
	 */
	var ipTree = new BST();
	ipTree.insert(4, "test4");
	ipTree.insert(1, "test1");
	ipTree.insert(10, "test10");
	ipTree.insert(2, "test2");
	ipTree.insert(3, "test3");
	ipTree.insert(9, "test9");
	ipTree.insert(8, "test8");
	ipTree.insert(5, "test5");
	ipTree.insert(7, "test7");
	ipTree.insert(6, "test6");

	ipTree.traverse(function (key, value) {
	    console.log("The value of " + key + " is " + value + ".");
	});

	console.log("Searching for 3 results in: " + ipTree.search(3));

	console.log("Min is " + ipTree.min());
	console.log("Max is " + ipTree.max());

	console.log("The successor of root is: " + ipTree.successor());
	console.log("The predecessor of root is: " + ipTree.predecessor());

});