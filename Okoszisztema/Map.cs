using System.Reflection.Metadata;

namespace Okoszisztema
{
    public class Map
    {
        Random r;
        int height_, width_, grass_chance_;
        List<List<Field>> map_;
        public List<List<Field>> Map_{ get { return map_; } }

        public Map(int height, int width,int grass_chance_)
        {
            this.height_ = height;
            this.width_ = width;
            this.grass_chance_ = grass_chance_;
            r= new Random();
            FillMap();
        }

        private void FillMap() {
            for (int i = 0; i < height_; ++i) {
                map_.Add(new List<Field>());
                for (int j = 0; j < width_; ++j) {
                    map_[i].Add(new GroundTile());
                }
            }
        }

        public void SaveMap(String filename) {
            StreamWriter st = new StreamWriter(filename);
            for (int i = 0; i < height_; ++i) {
                map_.Add(new List<Field>());
                for (int j = 0; j < width_; ++j) {
                    st.WriteLine(map_[i][j].ToString());
                }
            }
            st.Close();
        }

        public void GrowGrass() {
            if (r.Next(0, 101) >= grass_chance_) { 
                int x = r.Next(0,height_);
                int y = r.Next(0,width_);
                while (map_[x][y].GetType() != typeof(GroundTile) || map_[x][y].GetType() !=  typeof(Rabbit) || map_[x][y].GetType() != typeof(Fox)) { 
                     x = r.Next(0,height_);
                     y = r.Next(0,width_);
                }
                map_[x][y] = new Grass(); 
            }
        }

        public void RemoveField(int x,int y) {
            if (map_[x][y].GetType() != typeof(GroundTile)) {
                map_[x][y] = new GroundTile(); 
            }
        }
        
        public void SpawnEntities(int x,int y,IEntity entity) {
            if (map_[x][y].GetType() == typeof(GroundTile)) {
                if (typeof(Fox) == entity.GetType())
                {
                    map_[x][y] = new Fox();
                }
                else if (typeof(Rabbit) == entity.GetType()) { 
                
                    map_[x][y] = new Rabbit();
                }
             }
        }
        
    }
}
