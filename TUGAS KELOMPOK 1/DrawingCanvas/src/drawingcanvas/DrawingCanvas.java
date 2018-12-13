package drawingcanvas;

import java.awt.*;
import javax.swing.*;

public class DrawingCanvas extends Canvas {
//constructor
    Polygon p1, p2;
    public DrawingCanvas(){
        //Drawing a Triangle
        p1 = new Polygon();
        p1.addPoint(50, 500);
        p1.addPoint(100, 350);
        p1.addPoint(150, 500);
        
        //Drawing a Pentagon
        p2 = new Polygon();
        p2.addPoint(225, 500);
        p2.addPoint(200, 450);
        p2.addPoint(250, 400);
        p2.addPoint(300, 450);
        p2.addPoint(275, 500);
    }
    @Override
    public void paint (Graphics graphics){
        //Drawing a Line
        graphics.setColor(Color.WHITE);
        graphics.drawLine(250, 120, 400, 380);
        //Drawing a Rectangle
        graphics.setColor(Color.BLUE);
        graphics.fillRect(100, 100, 100, 200); //FILL
        graphics.setColor(Color.RED);
        graphics.drawRect(100, 100, 100, 200); //BORDER
        //Draw a Circle
        graphics.setColor(Color.RED);
        graphics.fillOval(380, 100, 150, 150); //FILL
        graphics.setColor(Color.YELLOW);
        graphics.drawOval(380, 100, 150, 150); //BORDER
        //Draw a Polygon
        graphics.setColor(Color.BLACK);
        graphics.drawPolygon(p1);
        graphics.setColor(Color.GREEN);
        graphics.fillPolygon(p1);
        //Draw a Polygon
        graphics.setColor(Color.MAGENTA);
        graphics.drawPolygon(p2);
        graphics.setColor(Color.ORANGE);
        graphics.fillPolygon(p2);
    }
    
    public static void main(String[] args) {
        DrawingCanvas canvas = new DrawingCanvas();
        JFrame frame = new JFrame();
        frame.setSize(600, 600);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.getContentPane().add(canvas);
        frame.setVisible(true);
    }
}
