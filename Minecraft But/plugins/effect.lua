name = "Saturate"

function effect ()
	out = bmp
	
	for x = 0,out.Width do
		for y = 0,out.Height do
			hsla = bmp.GetPixel(x, y).toHSLA();
			hsla.s = hsla.s + 0.5;
			out.SetPixel(x, y, hsla.toRGBA())
		end
	end
		
	return out
end