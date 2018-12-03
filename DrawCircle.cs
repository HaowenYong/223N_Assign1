using System;
using System.Drawing;
using System.Windows.Forms;

public class DrawCircle : Form{

	private Button draw = new Button();
	private Button clear = new Button();
	private Button quit = new Button();
	private Button radius100 = new Button();
	private Button radius200 = new Button();
	private Button radius300 = new Button();
	private Button color1 = new Button();
	private Button color2 = new Button();
	private Button color3 = new Button();

	private Color c = Color.White;
	private Color c1 = Color.White;
	private Color c2 = Color.White;
	private Color c3 = Color.White;
	private int radius = 100;

	public DrawCircle() {
		Text = "Draw Circle";
		Size = new Size(1000, 900);
		
		draw.Text = "draw";
		draw.Size = new Size(85, 25);
		draw.Location = new Point(100, 720);
		clear.Text = "clear";
		clear.Size = new Size(85, 25);
		clear.Location = new Point(100, 770);
		quit.Text = "quit";
		quit.Size = new Size(85, 25);
		quit.Location = new Point(100, 820);

		radius100.Text = "radius 100";
		radius100.Size = new Size(85, 25);
		radius100.Location = new Point(200, 720);
		radius200.Text = "radius 200";
		radius200.Size = new Size(85, 25);
		radius200.Location = new Point(200, 770);
		radius300.Text = "radius 300";
		radius300.Size = new Size(85, 25);
		radius300.Location = new Point(200, 820);

		color1.Text = "Red";
		color1.Size = new Size(85, 25);
		color1.Location = new Point(300, 720);
		color2.Text = "Blue";
		color2.Size = new Size(85, 25);
		color2.Location = new Point(300, 770);
		color3.Text = "Green";
		color3.Size = new Size(85, 25);
		color3.Location = new Point(300, 820);

		Controls.Add(draw);
		Controls.Add(clear);
		Controls.Add(quit);
		Controls.Add(radius100);
		Controls.Add(radius200);
		Controls.Add(radius300);
		Controls.Add(color1);
		Controls.Add(color2);
		Controls.Add(color3);

		draw.Click += new EventHandler(Draw_Click);
		clear.Click += new EventHandler(Clear_Click);
		quit.Click += new EventHandler(Quit_Click);
		radius100.Click += new EventHandler(radius100_Click);
		radius200.Click += new EventHandler(radius200_Click);
		radius300.Click += new EventHandler(radius300_Click);
		color1.Click += new EventHandler(color1_Click);
		color2.Click += new EventHandler(color2_Click);
		color3.Click += new EventHandler(color3_Click);
		
	}
	
	protected override void OnPaint(PaintEventArgs e) {
		Graphics board = e.Graphics;
		
		Pen bluepen = new Pen(Color.Blue, 2);
		board.DrawLine(bluepen, 1, 700, 999, 700);
		SolidBrush yellowbrush = new SolidBrush(Color.White);
		board.FillRectangle(yellowbrush, 0, 0, 1000, 700);

		Pen cpen = new Pen(c, 2);
		cpen.Color = c1;
		Rectangle info = CircleAlgorithms.getInformation(1000, 700, 100);
		board.DrawEllipse(cpen, info);
		cpen.Color = c2;
		info = CircleAlgorithms.getInformation(1000, 700, 200);
		board.DrawEllipse(cpen, info);
		cpen.Color = c3;
		info = CircleAlgorithms.getInformation(1000, 700, 300);
		board.DrawEllipse(cpen, info);

		base.OnPaint(e);
	}

	protected void Draw_Click(Object sender, EventArgs e){
		System.Console.WriteLine("you've clicked on the draw button.");
		
		switch(radius)
		{
			case 100: c1 = c; break;
			case 200: c2 = c; break;
			case 300: c3 = c; break;
		}
		Invalidate();
	}

	protected void Clear_Click(Object sender, EventArgs e){
		System.Console.WriteLine("you've clicked on the clear button.");
		c = Color.White;
		c1 = c;
		c2 = c;
		c3 = c;
		radius = 100;
		Invalidate();
	}

	protected void Quit_Click(Object sender, EventArgs e){
		System.Console.WriteLine("you've clicked on the quit butotn.");
		Close();
	}

	protected void radius100_Click(Object sender, EventArgs e){
		System.Console.WriteLine("you've selected radius 100.");
		radius = 100;
	}

	protected void radius200_Click(Object sender, EventArgs e){
		System.Console.WriteLine("you've selected radius 200.");
		radius = 200;
	}

	protected void radius300_Click(Object sender, EventArgs e){
		System.Console.WriteLine("you've selected radius 300.");
		radius = 300;
	}

	protected void color1_Click(Object sender, EventArgs e){
		System.Console.WriteLine("you've picked red.");
		c = Color.Red;
	}

	protected void color2_Click(Object sender, EventArgs e){
		System.Console.WriteLine("you've picked blue.");
		c = Color.Blue;
	}

	protected void color3_Click(Object sender, EventArgs e){
		System.Console.WriteLine("you've picked green.");
		c = Color.Green;
	}

}