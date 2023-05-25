import { Component } from '@angular/core';
import { OccupationService } from '../services/occupation.service';
import { InsuredPerson, PremiumService } from '../services/premium.service';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-premium-calculator',
  templateUrl: './premium-calculator.component.html',
  styleUrls: ['./premium-calculator.component.css']
})

export class PremiumCalculatorComponent {
  personName!: string;
  age!: number;
  dateOfBirth!: Date;
  occupationId!: number;
  sumInsured!: number;
  premiumAmount!: number;
  tpdPremiumAmount!: number;
  myForm!: FormGroup;
  formBuilder: any;
  insuredPerson: InsuredPerson = new InsuredPerson;

	constructor(
		private occupationService: OccupationService,private premiumService: PremiumService,public fb: FormBuilder) {

      this.myForm = this.fb.group({
        selectedOption: [''] // Set initial value or desired default value
      });
     }
    occupations: Array<any> = new Array<any>();
    
    ngOnInit() {
   
     this.occupationService.getOccupations().subscribe(
      (response) => {                           
        console.log('response received')
        this.occupations = response; 
      },
      (error) => {                             
        console.error('Request failed with error')
   
      },
      () => {                                  
        console.error('Request completed')      
      
      })

  
    }
  calculatePremium() {
   
     this.insuredPerson.PersonName = this.personName;
     this.insuredPerson.DateofBirth = this.dateOfBirth;
   this.insuredPerson.Age = this.age;
   this.insuredPerson.OccupationID = this.occupationId;
   this.insuredPerson.SumInsured = this.sumInsured;
 
   this.premiumService.calculateDeath(this.insuredPerson).subscribe(
    (response) => {                           
      console.log('response received')
      this.premiumAmount=  response; 
    },
    (error) => {                            
      console.error('Request failed with error')
  
    },
    () => {                                  
      console.error('Request completed')     
   
    });

    this.premiumService.calculateTPDDeath(this.insuredPerson).subscribe(
      (response) => {                          
        console.log('response received')
        this.tpdPremiumAmount=  response; 
      },
      (error) => {                              
        console.error('Request failed with error')

      },
      () => {                                  
        console.error('Request completed')     
      
      });
}
}
