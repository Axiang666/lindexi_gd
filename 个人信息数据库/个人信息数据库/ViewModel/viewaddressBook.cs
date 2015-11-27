﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 个人信息数据库.model;
namespace 个人信息数据库.ViewModel
{
    public class viewaddressBook:notify_property
    {
        public viewaddressBook(viewModel _viewModel,model.model _model)
        {
            this._model = _model;
            this._viewModel = _viewModel;

            _viewModel.addressbook = this;
            _model.addressbook = laddressBook;
           
        }

        public caddressBook addressBook
        {
            set
            {
                _addressBook = value;
                OnPropertyChanged();
            }
            get
            {
                return _addressBook;
            }
        } 
        public System.Collections.ObjectModel.ObservableCollection<caddressBook>
        /*public List<caddressBook>*/ laddressBook
        {
            set;
            get;
        } =
           //new List<caddressBook>()
           new System.Collections.ObjectModel.ObservableCollection<caddressBook>()
           {
                //new caddressBook()
                //{
                //    name ="通讯人姓名",
                //    contact ="联系方式",
                //    address ="工作地点",
                //    city ="城市",
                //    comment ="备注"
                //},
                new caddressBook()
                {
                    name ="张三",
                    contact ="1",
                    address ="中国",
                    city =" ",
                    comment =" "
                } ,
                new caddressBook()
                {
                    name ="张三",
                    contact ="1",
                    address ="中国",
                    city =" ",
                    comment =" "
                }
            };
        //public void warn()
        //{

        //}
        public System.Windows.Visibility visibility
        {
            set
            {
                _visibility = value;
                OnPropertyChanged();
            }
            get
            {
                return _visibility;
            }
        }
        public new string reminder
        {
            set
            {
                _model.reminder = value;
            }
            get
            {
                return _model.reminder;
            }
        }
        public void add()
        {
            reminder = "添加通讯";
        }
        public void delete()
        {
            reminder = "删除通讯";
        }

        public void select()
        {
            reminder = "查询通讯";
            
        }

        public void modify()
        {
            reminder = "修改通讯";
        }

        public void eliminate()
        {
            
            reminder = "清除";
        }
        public void navigated()
        {
            warn = "点击修改把现有表修改到数据库，按delete删除行,双击修改列";
        }
        public void selectitem(System.Collections.IList item)
        {
            addressBook = item[0] as caddressBook;
        }
        public string warn
        {
            set
            {
                _warn = value;
                warnvisibility = System.Windows.Visibility.Visible;
                OnPropertyChanged();
            }
            get
            {
                return _warn;
            }
        }

        public System.Windows.Visibility warnvisibility
        {
            set
            {
                _warnvisibility = value;
                OnPropertyChanged();
            }
            get
            {
                return _warnvisibility;
            }
        }       
        private System.Windows.Visibility _warnvisibility=System.Windows.Visibility.Hidden;
        private string _warn = "输入";
        private System.Windows.Visibility _visibility = System.Windows.Visibility.Hidden;
        private viewModel _viewModel;    
        private model.model _model
        {
            set;
            get;
        }

        private caddressBook _addressBook = new caddressBook();
    }
}
