package be.colorfield;

import java.util.*;

/**
 * Promenade
 *
 * @author christophe
 */
public class Promenade {

	private static int numOperations;
	private static int from, to;
	private static List<Path> results;

	// 2 -> 9
	// 1) 2 → 4 → 8 → 16 → 18 → 9 (+2, *2, *2, *2, /2)
	// 2) 2 → 1 → 3 → 5 → 7 → 9 (/2, +2, +2, +2, +2)
	// 3) 2 → 4 → 8 → 10 → 5 → 7 → 9 ou 2 → 4 → 6 → 12 → 14 → 7 → 9
	// 4) 2 → 4 → 6 → 8 → 16 → 32 → 34 → 36 → 18 → 9
	private static void walk(int a, int b) {

		// order
		if (a <= b) {
			from = a;
			to = b;
		} else {
			from = b;
			to = a;
		}

		// include other trivial cases (non divisble next, ...)
		if (from == to) {
			// don't walk
			// @todo handle exception
		} else {
			Path p = new Path(from, to);
		}

    /*
    for (int k = from; k <= to; ++k) {
      System.out.print(k + " ");
    }
    */

    /*
    if (start <= stop) {
      for (int k = start; k <= stop; ++k) {
        System.out.print(k + " ");
      }
    } else {
      for (int k = start; k >= stop; --k) {
        System.out.print(k + " ");
      }
    }
    */
	}

	/**
	 * @param args the command line arguments
	 */
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int start = s.nextInt();
		int stop = s.nextInt();
		Promenade.walk(start, stop);
	}
}

