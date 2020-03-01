name = "Randomize (keep alpha)"

function effect ()
	out = bmp
	alpha = bmp.toVector2List()
	
	for x = 0,out.Width do
		for y = 0,out.Height do
			if alpha.contains(x,y) then
				rand = Math.GetRandom(0, alpha.count, x + y)
				out.SetPixel(x, y, bmp.GetPixel(alpha.get(rand).x, alpha.get(rand).y))
				alpha.remove(rand)
				alpha.remove(x, y)
			end
		end
	end
		
	return out
end