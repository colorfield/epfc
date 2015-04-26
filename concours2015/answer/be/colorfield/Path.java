package be.colorfield;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

/**
 * Stores a list of breadcrumbs
 */
public class Path {

	public List<Breadcrumb> breadcrumbs;
	public int from;
	public int to;
	public int currentBreadcrumbRank;

	public Path(int from, int to){
		this.from = from;
		this.to = to;
		this.currentBreadcrumbRank = 0;
		breadcrumbs = new LinkedList<Breadcrumb>();
		// the path initializes the first Breadcrumb
		// the breadcrumbs are adding themselves to the path after
		new Breadcrumb(from, this);
	}
}
