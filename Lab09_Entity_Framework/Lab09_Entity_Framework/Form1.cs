using Lab09_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_Entity_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Category> GetCategories()
        {
            // Khởi tạo đối tượng context
            var dbContext = new RestaurantContext();
            // Lấy danh sách tất cả nhóm thức ăn, sắp xếp theo tên
            return dbContext.Category.OrderBy(x => x.Name).ToList();
        }


        private void ShowCategories()
        {
            // Xóa tất cả các nút hiện có trên cây tvwCategory.Nodes.Clear();
            // Tạo danh sách loại nhóm thức ăn, đồ uống
            // Tên của các loại này được hiển thị trên các nút mức 2
            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Food] = "Do ăn",
                [CategoryType.Drink] = "Thức uống"
            };

            // Tạo nút gốc của cây
            var rootNode = tvwCategory.Nodes.Add("Tất cȧ");
            // Lấy danh sách nhóm đồ ăn, thức uống
            var categories = GetCategories();
            // Duyệt qua các loại nhóm thức ăn
            foreach (var cateType in cateMap)
            {
                // Tạo các nút tương ứng với loại nhóm thức ăn
                var childNode = rootNode.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType.Key;

                foreach (var category in categories)
                {
                    if (category.Type != cateType.Key) continue;
                    var grantChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                    grantChildNode.Tag= category;
                }
            }

            tvwCategory.ExpandAll();

            tvwCategory.SelectedNode= rootNode;
        }


        private List<FoodModel> GetFoodByCategory(int? categoryId)
        {
            // Khởi tạo đối tượng context
            var dbContext = new RestaurantContext();
            // Tạo truy vấn lấy danh sách món ăn
            var foods= dbContext. Food. AsQueryable();
            // Nếu mã nhóm món ăn khác null và hợp lệ
            if (categoryId != null && categoryId > 0)
            {
                foods= foods.Where(x => x.FoodCategoryID == categoryId);
            }
            // Thì tìm theo mã số nhóm thức ăn
            // Sắp xếp đồ ăn, thức uống theo tên và trả về // danh sách chứa đầy đủ thông tin về món ăn.
            return foods
            .OrderBy(x => x.Name)
            .Select(x => new FoodModel()
            {
                Id = x.Id,
                Name = x.Name,
                Unit = x.Unit,
                Price = x.Price,
                Notes = x.Notes,
                CategoryName = x.Category.Name
            })
            .ToList();
        }


        private List<FoodModel> GetFoodByCategoryType(CategoryType cateType)
        {
            var dbContext = new RestaurantContext();
            // Tìm các món ăn theo loại nhóm thức ăn (Category Type). // Sắp xếp đồ ăn, thức uống theo tên và trả về
            // danh sách chứa đầy đủ thông tin về món ăn.
            return dbContext.Food
            .Where(x => x.Category.Type ==cateType)
            .OrderBy(x => x.Name)
            .Select(x => new FoodModel()
            {
                Id = x.Id,
                Name = x.Name,
                Unit = x.Unit,
                Price=x.Price,
                Notes= x.Notes,
                CategoryName = x.Category.Name
            })
            .ToList();
        }


        private void ShowFoodsForNode(TreeNode node)
        {
            // Xóa danh sách thực đơn hiện tại khỏi listview
            lvwFood.Items.Clear();
            // Nếu node = null, không cần xử lý gì thêm
            if (node == null) return;
            // Tạo danh sách để chứa danh sách các món ăn tìm được
            List<FoodModel> foods = null;
            // Nếu nút được chọn trên TreeView tương ứng với // loại nhóm thức ăn (Category Type) (mức thứ 2 trên cây)
            if (node.Level == 1)
            {
                var categoryType = (CategoryType)node.Tag;
                foods = GetFoodByCategoryType(categoryType);
            }
            else
            {
                // Thì lấy danh sách món ăn theo loại nhóm
                
                // Ngược lại, lấy danh sách món ăn theo thể loại 1/ Nếu nút được chọn là 'Tất cả' thì lấy hết
                var category = node. Tag as Category;
                foods = GetFoodByCategory(category?.Id);
                // Gọi hàm để hiển thị các món ăn lên ListView 
            }
            ShowFoodsOnListView(foods);
        }

        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            // Duyệt qua từng phần tử của danh sách foodt
            foreach (var foodItem in foods)
            {
                // Tạo item tương ứng trên ListView
                var item = lvwFood.Items.Add(foodItem.Id.ToString());
                // và hiển thị các thông tin của món ăn
                item. SubItems.Add(foodItem.Name); item. SubItems.Add(foodItem. Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }


                private void Form1_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }
    }
}
