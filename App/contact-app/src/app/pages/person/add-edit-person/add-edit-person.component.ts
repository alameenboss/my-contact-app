import { ViewChild } from '@angular/core';
import { Component, OnInit } from '@angular/core';

import { FormBuilder, Validators, NgForm, FormArray, FormControl, FormGroup } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { PersonService } from 'src/app/services/person/person.service';
@Component({
  selector: 'app-add-edit-person',
  templateUrl: './add-edit-person.component.html',
  styleUrls: ['./add-edit-person.component.scss']
})
export class AddEditPersonComponent implements OnInit {
  @ViewChild('formDirective') private formDirective: NgForm;
  title: string;
  isSaving: boolean;
  constructor(private fb: FormBuilder,
    private personService: PersonService,
    private router: Router,
    private _snackBar: MatSnackBar) { }

  ngOnInit() {
    this.title = 'Add Person'
  }

  personForm = this.fb.group({
    firstName: [null, Validators.required],
    lastName: [null, Validators.required],
    phones: new FormArray([this.PhoneFormGroup]),
    emails: new FormArray([this.EmailFormGroup]),
  });

  phones = this.personForm.get("phones") as FormArray;

  get PhoneFormGroup(): FormGroup {
    return new FormGroup({
      number: new FormControl('', Validators.required),
      isPrimary: new FormControl(false, Validators.required)
    })
  }

  addPhone() {
    this.phones.push(this.PhoneFormGroup);
  }

  emails = this.personForm.get("emails") as FormArray;

  get EmailFormGroup(): FormGroup {
    return new FormGroup({
      email: new FormControl('', Validators.required)
    })
  }

  addEmail() {
    this.emails.push(this.EmailFormGroup);
  }


  onSubmit() {
    if (this.personForm.valid) {
      this.isSaving = true;
      let request = this.getPersonRequest();
      this.personService.addPerson(request).subscribe(data => {
        if (data === null) return;
        this.clearForm();
        this.isSaving = false;
        this.openSnackBar("New Person added!", "Ok")
      }, error => {
        this.isSaving = false;
        console.log(error)
      })

    }
  }

  getPersonRequest() {
    return {
      firstName: this.personForm.controls["firstName"].value,
      lastName: this.personForm.controls["lastName"].value
    }
  }

  clearForm() {
    this.personForm.reset();
    this.formDirective.resetForm();
  }

  openSnackBar(message: string, action: string) {
    this._snackBar.open(message, action, {
      duration: 1000,
      horizontalPosition: 'right',
      verticalPosition: 'top',
    });
  }

  listPerson() {
    this.router.navigateByUrl(`person`);
  }

}
