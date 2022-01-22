import { Component, OnInit } from '@angular/core';
import { VMDepartment } from 'src/model/VMDepartment';
import { DepartmentService } from 'src/Service/deparmentService';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.css']
})
export class DepartmentComponent implements OnInit {
  liDept!:VMDepartment[]

  constructor(private DeptServ:DepartmentService) { }

  ngOnInit(): void {
    this.DeptServ.Load().subscribe(
      data=>{
        this.liDept=data
        
      }

    );
  }

}
