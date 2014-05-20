
/**
 * Implements composite design pattern (node)
 * http://www.joezimjs.com/javascript/javascript-design-patterns-composite/
 */
var SetComposite = function (heading, id) {
    this.children = [];
    this.element = $('<div id="' + id + '" class="composite-set"></div>')
        .append('<h2>' + heading + '</h2>');
}
 
SetComposite.prototype = {
    add: function (child) {
        this.children.push(child);
        this.element.append(child.getElement());
    },
     
    remove: function (child) {    
        for (var node, i = 0; node = this.getChild(i); i++) {
            if (node == child) {
                this.children.splice(i, 1);
                this.element.detach(child.getElement());
                return true;
            }
             
            if (node.remove(child)) {
                return true;
            }
        }
         
        return false;
    },
     
    getChild: function (i) {
        return this.children[i];
    },
     
    hide: function () {
        for (var node, i = 0; node = this.getChild(i); i++) {
            node.hide();
        }
         
        this.element.hide(0);
    },
     
    show: function () {    
        for (var node, i = 0; node = this.getChild(i); i++) {
            node.show();
        }
         
        this.element.show(0);
    },

    calculate: function () {    
        // @todo to be implemented
    },

     
    getElement: function () {
        return this.element;
    }
}

/**
 * Implements composite design pattern (leaf)
 */
var ItemComponent = function (name, id) {
    this.children = [];
     
    this.element = $('<div>Leaf '+ name +'</div>')
        .attr('id', id)
        .attr('name', name);
}
 
ItemComponent.prototype = {
    // Due to this being a leaf, it doesn't use these methods,
    // but must implement them to count as implementing the
    // Composite interface
    add: function () { },
     
    remove: function () { },
     
    getChild: function () { },
     
    hide: function () {
        this.element.hide(0);
    },
     
    show: function () {    
        this.element.show(0);
    },

    calculate: function () {    
        // @todo to be implemented
    },
     
    getElement: function () {
        return this.element;
    }
}

// main
$( document ).ready(function() {
	var set = new SetComposite('', 'all-subsets');
	var subset1 = new SetComposite('Subset 1', 'subset-1');
	var subset2 = new SetComposite('Subset 2', 'subset-2');
	var leaf1 = new ItemComponent('A', 'leaf-a');
	var leaf2 = new ItemComponent('B', 'leaf-b');
	var leaf3 = new ItemComponent('C', 'leaf-c');
	var leaf4 = new ItemComponent('D', 'leaf-d');
	 
	subset1.add(leaf1);
	subset1.add(leaf2);
	 
	subset2.add(leaf3);
	subset2.add(leaf4);
	 
	set.add(subset1);
	set.add(subset2);
	 
	// Make sure to add the top container to the body, 
	// otherwise it'll never show up.
	set.getElement().appendTo('#result');
	set.show();
	
});