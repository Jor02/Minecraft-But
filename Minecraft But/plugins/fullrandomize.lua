name = "Randomize"

function effect ()
	out = bmp
	
	for x = 0,out.Width do
		for y = 0,out.Height do
			out.SetPixel(x, y, bmp.GetPixel(Math.GetRandom(0, out.Width, x), Math.GetRandom(0, out.Height, y)))
		end
	end
		
	return out
end

function getAlpha ()
	alpha = bmp

	for x = 0,out.Width do
		for y = 0,out.Height do
			
		end
	end
end