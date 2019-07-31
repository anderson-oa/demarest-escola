import { Component, OnInit, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { forkJoin } from 'rxjs';
import { FormGroup, Validators, FormBuilder, FormGroupDirective, NgForm } from '@angular/forms';

@Component({
  selector: 'app-inserir-nota',
  templateUrl: './inserir-nota.component.html',
  styleUrls: ['./inserir-nota.component.scss']
})
export class InserirNotaComponent implements OnInit {

  @ViewChild('formDirective') private formDirective: NgForm;

  private API: string = "http://localhost:5000"

  inserirNotaForm: FormGroup;
  students: Array<any> = [];
  semesters: Array<any> = [];
  studentClasses: Array<any> = [];
  loading: boolean = false;

  constructor(private http: HttpClient,
    private formBuilder: FormBuilder) {
  }

  ngOnInit() {
    this.buildForm();
    forkJoin(
      this.http.get<any>(`${this.API}/student`),
      this.http.get<any>(`${this.API}/semester`),
    ).subscribe(([students, semesters]) => {
      this.students = students;
      this.semesters = semesters;
    });
  }

  getClasse(id: Number) {
    this.http.get<any>(`${this.API}/student/classes/${id}`).subscribe(studentClasses => {
      this.studentClasses = studentClasses;
      this.inserirNotaForm.get("studentClasseId").enable();
    })
  }

  buildForm() {
    this.inserirNotaForm = this.formBuilder.group({
      studentId: ['', Validators.required],
      studentClasseId: [{ value: '', disabled: true }, Validators.required],
      semester: ['', Validators.required],
      grade: ['', Validators.required]
    });
  }

  submit(formDirective: FormGroupDirective) {
    if (this.inserirNotaForm.invalid) return;
    this.loading = true;
    this.http.post(`${this.API}/exam`, this.inserirNotaForm.value).subscribe(() => {
      this.loading = false;
      this.inserirNotaForm.reset();
      this.formDirective.resetForm();
    }, (err) => {
      console.log(err);
      this.loading = false;
    });
  }

}
