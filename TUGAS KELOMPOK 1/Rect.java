import java.awt.Color;
import java.awt.Graphics;
import javax.swing.JFrame;
import javax.swing.JPanel;

public class Rect extends JPanel {
   public static void main(String[] a) {
      JFrame f = new JFrame();
      f.setSize(400, 400);
      f.add(new Rect());
      f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      f.setVisible(true);
   }
   public void paint(Graphics g) {
      g.setColor(Color.BLUE);
      g.fillRect (30, 60, 120, 240);
   }
}