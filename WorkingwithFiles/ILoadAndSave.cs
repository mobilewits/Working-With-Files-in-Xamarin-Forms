using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WorkingwithFiles
{
	public interface ILoadAndSave
	{
		void SaveText (string filename, string text);
		string LoadText (string filename);



	}


}

