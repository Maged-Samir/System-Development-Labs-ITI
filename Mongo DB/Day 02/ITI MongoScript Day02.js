db.instructors.find()

db.instructors.find({salary:{ $gt: 4000 } },{ firstName: 1, salary: 1, _id: 0 })

db.instructors.find({age:{$lte:25}})


db.instructors.find({"address.city":"mansoura","address.street":{ $in:[ 10, 14 ]}},
{ firstName: 1, address: { city: "mansoura"}, salary: 1, _id: 0 })


db.instructors.find()

db.instructors.find({$and:[{"courses":"js"},{"courses":"bootstrap"}]})

db.instructors.find({courses:{$exists:true}}).forEach(ins=>{print(`${ins.firstName}  ${ins.courses.length}`)})


db.instructors.aggregate([{$match: {$and: [{ firstName: { $exists: true } },{ lastName: { $exists: true } }]}},{
$project: {fullName: { $concat: [ "$firstName", " ", "$lastName" ] },age: 1}},{$sort: {fullName: 1,lastName: -1}}],{ $out: "instructorsData" })
   

db.instructors.find({$or:[{"firstName":"mohammed"},{"lastName":"mohammed"}]})


db.instructors.find({$and:[{"firstName":"ebtesam"},{"courses":{$size:5}}]})
db.instructors.deleteOne({$and:[{"firstName":"ebtesam"},{courses:{$size:5}}]})


db.instructors.updateMany({},{$set:{Active:"True"}})
db.instructors.find()


db.instructors.updateMany({"firstName":"mazen","lastName":"mohammed",courses:"EF"},{$set:{"courses.$":"jquery"}})
db.instructors.find()


db.instructors.updateMany({_id:7},{$addToSet:{courses:"test"}})

db.instructors.updateMany({"firstName":"Maged","lastName":"Samir"},{$unset:{courses:"Remove"}})

db.instructors.updateMany({}, {$rename: {"address": "fullAddress"}})

db.instructors.updateMany({"courses":{ "$size":3}},{"$inc":{"salary":-500}})
db.instructors.find()


db.instructors.updateOne({"firstName":"noha","lastName":"hesham"},{"$set":{"fullAddress.street":20}})


