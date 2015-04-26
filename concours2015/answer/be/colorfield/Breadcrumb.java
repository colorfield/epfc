package be.colorfield;

import java.util.LinkedList;
import java.util.List;
import java.util.Iterator;

/**
 * A Breadcrumb contains a current position and 3 possible directions.
 */
public class Breadcrumb {

	public int currentResult;
	public int rank; // current breadcrumb rank when inserted in the path
	public boolean retain; // used for path retrieval
	public List<Direction> directions;
	private Path path;

	public Breadcrumb(int currentResult, Path path){
		this.currentResult = currentResult;
		this.path = path;
		this.path.currentBreadcrumbRank++; // @todo check if this is right
		this.rank = this.path.currentBreadcrumbRank;
		this.retain = true; // by default, we are on a right path
		this.directions = new LinkedList<Direction>();

		Direction dAdd = new Direction(Direction.ADD, currentResult);
		Direction dMul = new Direction(Direction.MUL, currentResult);
		Direction dDiv = new Direction(Direction.DIV, currentResult);
		directions.add(dAdd);
		directions.add(dMul);
		directions.add(dDiv);

		Iterator<Direction> directionsIterator = directions.iterator();
		boolean hasReachedDestination = false;

		while(directionsIterator.hasNext() || hasReachedDestination){
			Direction nextDirection = directionsIterator.next();
			if(!nextDirection.isLeaf && nextDirection.nextResult != this.path.to){
				Breadcrumb nextBreadcrumb = new Breadcrumb(nextDirection.nextResult, this.path);
				// always compare the breadcrumb to the other breadcrumb currentResult in the path
				// if they have an upper rank,
				Iterator breadcrumbIterator = this.path.breadcrumbs.iterator();
				while(breadcrumbIterator.hasNext()){
					// @todo why this typecast is necessary?
					Breadcrumb pathBreadcrumb = (Breadcrumb) breadcrumbIterator.next();
					if(pathBreadcrumb.currentResult == nextBreadcrumb.currentResult){
						if(pathBreadcrumb.rank > nextBreadcrumb.rank){
							pathBreadcrumb.retain = false;
						}
					}
				}
				this.path.breadcrumbs.add(nextBreadcrumb);
				nextDirection.nextBreadcrumb = nextBreadcrumb;
			}else{
				// we have got a solution
				if(nextDirection.nextResult == this.path.to){
					hasReachedDestination = true;
				}
			}
		}

		// if we are on destination print the breadcrumbs flagged as retained
		if(hasReachedDestination){
			System.out.println("Reached destination");
		}


	}


}
