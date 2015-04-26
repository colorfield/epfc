package be.colorfield;

/**
 * A direction belongs to a Breadcrumb
 */
public class Direction {

	public static final int DIV = 0;
	public static final int ADD = 1;
	public static final int MUL = 2;

	private int currentResult;
	public int operation;
	public int nextResult;
	public Breadcrumb nextBreadcrumb;
	public boolean isLeaf; // we must stop here, no more next Breadcrumb

	protected boolean isCurrentDivisible(){
		return this.currentResult % 2 == 0;
	}

	public Direction(int operation, int currentResult){
		this.operation = operation;
		this.currentResult = currentResult;
		switch (operation){
			case DIV:
				if(isCurrentDivisible()){
					this.isLeaf = false;
					this.nextResult = currentResult / 2;
				}else{
					this.isLeaf = true;
				}
				break;
			case ADD:
				this.nextResult = currentResult + 2;
				break;
			case MUL:
				this.nextResult = currentResult * 2;
				// if we have the same result as and addition, ignore this path
				// the path kept is the addition
				if(this.nextResult == (currentResult + 2)){
					this.isLeaf = true;
				}
				break;
		}

	}

}
