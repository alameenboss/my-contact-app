import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { PersonService } from 'src/app/services/person/person.service';
import { MatDialog } from '@angular/material/dialog';
import { ConfiramtionComponent } from '../../shared/confiramtion/confiramtion.component';
import { MatSnackBar, MatSnackBarHorizontalPosition, MatSnackBarVerticalPosition } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-list-person',
  templateUrl: './list-person.component.html',
  styleUrls: ['./list-person.component.scss']
})
export class ListPersonComponent implements AfterViewInit, OnInit {
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  displayedColumns: string[] = ['firstName', 'lastName', 'action'];
  dataSource = new MatTableDataSource([]);

  horizontalPosition: MatSnackBarHorizontalPosition = 'right';
  verticalPosition: MatSnackBarVerticalPosition = 'top';

  constructor(private personService: PersonService,
    private _snackBar: MatSnackBar,
    private router: Router,
    public dialog: MatDialog) {

  }

  ngOnInit() {

  }

  ngAfterViewInit() {
    this.getAllPerson();
  }

  getAllPerson() {
    this.personService.getAll().subscribe(data => {
      this.dataSource = new MatTableDataSource(data);
      this.dataSource.sort = this.sort;
      this.dataSource.paginator = this.paginator;
    })
  }

  showRandomPerson() {
    this.personService.getRandomUser().subscribe((data :any)=> {
      let randomuser =  data.results.map(x=> {
        return {
          firstName : x.name.first,
          lastName : x.name.last
        }
      })

      this.dataSource = new MatTableDataSource(randomuser);
      this.dataSource.sort = this.sort;
      this.dataSource.paginator = this.paginator;
    })
  }

  addPerson(){
    this.router.navigateByUrl(`person/addperson`);
  }

  editPerson(person) {
    this.router.navigateByUrl(`person/editperson/${person.id}`);
  }

  deletePerson(person) {
    const dialogRef = this.dialog.open(ConfiramtionComponent, {
      width: '400px',
      data: { id: person.id },
      disableClose:true
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result === true) {
        this.personService.delete(person.id).subscribe(data => {
          this.openSnackBar('Deleted Succesfully!', 'Ok');
          this.getAllPerson();
        });
      }
      this.getAllPerson();
    });
  }

  openSnackBar(message: string, action: string) {
    this._snackBar.open(message, action, {
      duration: 1000,
      horizontalPosition: this.horizontalPosition,
      verticalPosition: this.verticalPosition,
    });
  }
}
